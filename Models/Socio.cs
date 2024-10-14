using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Socio : Cliente
    {
        public List<Pago> Pagos { get; private set; }

        public Socio(DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, bool activo = true, bool esApto = true)
            : base(fechaIngreso, nombre, apellido, dni, direccion, telefono, email, activo, esApto)
        {
            Pagos = new List<Pago>();
        }

        public void AltaSocio()
        {
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO socio 
                     (Nombre, Apellido, DNI, Direccion, Telefono, Email, FechaIngreso, Activo, EsApto) 
                     VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @email, @fechaIngreso, @activo, @esApto)";

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
                        MessageBox.Show("Socio registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al registrar socio: {ex.Message}\nCódigo del error: {ex.Number}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar socio: " + ex.Message);
                }

            }
        }


        // Método para agregar un pago a la base de datos
        public void AgregarPago(Pago pago)
        {
            Pagos.Add(pago);
            // Guardar el pago en la base de datos
        }

        public List<Pago> ObtenerPagos()
        {
            // Recuperar pagos desde la base de datos
            return Pagos;
        }
    }

}
