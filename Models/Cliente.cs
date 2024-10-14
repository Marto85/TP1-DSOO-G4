using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Cliente
    {
        public int IdCliente { get; private set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public bool EsApto { get; set; }
        public bool PagoVencido { get; set; } 


        public Cliente(string nombre, string apellido, bool activo, bool esApto, bool pagoVencido)
        {
            FechaIngreso = DateTime.Now;
            Nombre = nombre;
            Apellido = apellido;
            Activo = activo;
            EsApto = esApto;
            PagoVencido = pagoVencido;
        }

        public Cliente(DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, bool activo = true, bool esApto = true, bool pagoVencido = false)
        {
            FechaIngreso = fechaIngreso;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }

        public void AltaCliente(Conexion conexion)
        {
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO cliente 
                             (Nombre, Apellido, DNI, Direccion, Telefono, Email, Activo, EsApto, FechaIngreso) 
                             VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @email, @activo, @esApto, @fechaIngreso)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", this.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", this.Apellido);
                        cmd.Parameters.AddWithValue("@dni", this.DNI);
                        cmd.Parameters.AddWithValue("@direccion", this.Direccion);
                        cmd.Parameters.AddWithValue("@telefono", this.Telefono);
                        cmd.Parameters.AddWithValue("@email", this.Email);
                        cmd.Parameters.AddWithValue("@activo", this.Activo);
                        cmd.Parameters.AddWithValue("@esApto", this.EsApto);
                        cmd.Parameters.AddWithValue("@fechaIngreso", this.FechaIngreso);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error
                    MessageBox.Show("Error al registrar cliente: " + ex.Message);
                }
            }
        }

    }


}
