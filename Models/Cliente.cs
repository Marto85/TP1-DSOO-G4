using DSOO_Grupo4_TP1.Datos;
using DSOO_Grupo4_TP1.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool EsSocio { get; set; }
        public bool EsApto { get; set; }

        public decimal AbonoMensualSocios { get; set; }

        public string ImagenPerfil { get; set; }

        private List<Cliente> listaDeClientes = new List<Cliente>();

        public Cliente() { }

        public Cliente(DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, string imagenPerfil, decimal? abonoMensualSocios = null, bool esSocio = false, bool esApto = true)
        {
            FechaIngreso = fechaIngreso;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            EsSocio = esSocio;
            EsApto = esApto;
            ImagenPerfil = imagenPerfil;

            // Solo asignar abono si es un socio
            if (esSocio && abonoMensualSocios.HasValue)
            {
                AbonoMensualSocios = abonoMensualSocios.Value;
            }
        }

        public decimal GetAbonoMensualSocios()
        {
            return AbonoMensualSocios;
        }

        public void SetAbonoMensualSocios(decimal abonoMensualSocios)
        {
            AbonoMensualSocios = abonoMensualSocios;
        }

        public bool AltaCliente()
        {
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
              
                try
                {
                    conn.Open();

                    // Verificar si el DNI ya existe
                    string checkQuery = "SELECT COUNT(*) FROM cliente WHERE DNI = @dni";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@dni", DNI);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Error: El cliente con este DNI ya existe.", "Error de duplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; 
                        }
                    }

                    // Definir el query según si es socio o no
                    string query = @"INSERT INTO cliente 
                (FechaIngreso, Nombre, Apellido, DNI, Direccion, Telefono, Email, EsSocio, EsApto, Imagen_Perfil";

                    if (EsSocio)
                    {
                        query += ", AbonoMensualSocios";
                    }

                    query += ") VALUES (@fechaIngreso, @nombre, @apellido, @dni, @direccion, @telefono, @email, @esSocio, @esApto, @imagen_Perfil";

                    if (EsSocio)
                    {
                        query += ", @abonoMensualSocios";
                    }

                    query += ")";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@fechaIngreso", FechaIngreso);
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@dni", DNI);
                        cmd.Parameters.AddWithValue("@direccion", Direccion);
                        cmd.Parameters.AddWithValue("@telefono", Telefono);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@esSocio", EsSocio);
                        cmd.Parameters.AddWithValue("@esApto", EsApto);
                        cmd.Parameters.AddWithValue("@imagen_Perfil", ImagenPerfil);

                        if (EsSocio)
                        {
                            cmd.Parameters.AddWithValue("@abonoMensualSocios", GetAbonoMensualSocios());
                        }

                        cmd.ExecuteNonQuery();

                        // Obtener el ID del cliente recién insertado
                        MySqlCommand getIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn);
                        int idGenerado = Convert.ToInt32(getIdCmd.ExecuteScalar());
                        this.IdCliente = idGenerado; 

                        if (EsSocio)
                        {
                            MessageBox.Show("Socio registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show($"Se procede a entregar al Socio con nombre {Nombre} {Apellido} el carnet que lo acredita como socio de Club Sports");
                        }
                        else {
                            MessageBox.Show("Cliente registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show($"Se procede a entregar al Cliente con nombre {Nombre} {Apellido} el carnet que lo acredita a ingresar a las actividades.");
                        }
                    }
                        return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ImagenPerfil}Error al registrar cliente: {ex.Message}\nCódigo del error: {ex.Number}");
                    return false;
                }

            }
        }

        private int ObtenerTipoDePagoId(int meses)
        {
            switch (meses)
            {
                case 1: return 3;  // Mensual
                case 3: return 4;  // Trimestral
                case 6: return 5;  // Semestral
                case 12: return 6; // Anual
                default: throw new ArgumentException("Duración de abono inválida.");
            }
        }

    }
}
