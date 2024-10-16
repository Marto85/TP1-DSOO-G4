using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Actividad
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public decimal Precio { get; private set; } 
        public string Horario { get; private set; }
        public int CuposDisponibles { get; private set; }
        public string Profesor { get; set; }
        public DateTime FechaVencimiento { get; private set; }


        public Actividad(int id, string nombre, string descripcion, decimal precio, string horario, int cuposDisponibles, string profesor)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Horario = horario;
            CuposDisponibles = cuposDisponibles;
            Profesor = profesor;
        }

        public bool ChequearCupo()
        {
            if (CuposDisponibles > 0)
            {
                return true;
            }
            return false;
        }

        public bool ReservaCupo()
        {
            if (CuposDisponibles > 0)
            {
                CuposDisponibles--;
                return true;
            }

            return false;
        }

        public void LiberarCupo()
        {
            CuposDisponibles++;
        }

        public void AgregarInscripto(Cliente cliente)
        {
        }

        public bool InscribirCliente(Cliente cliente)
        {
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();

                    if (cliente.EsSocio)
                    {
                        // Verificar si el socio tiene el pago al día
                        Pago pago = new Pago();
                        bool pagoAlDia = pago.VerificarPagoSocio(cliente.IdCliente);

                        if (!pagoAlDia)
                        {
                            MessageBox.Show("El socio no tiene el pago al día. No puede inscribirse en la actividad.", "Error de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        // Verificar que no esté inscrito en más de 3 actividades
                        string queryActividadesSocio = "SELECT COUNT(*) FROM Actividad_Cliente WHERE IdCliente = @IdCliente AND EsSocio = 1";
                        using (MySqlCommand cmdActividadesSocio = new MySqlCommand(queryActividadesSocio, conn))
                        {
                            cmdActividadesSocio.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                            int actividadesInscriptas = Convert.ToInt32(cmdActividadesSocio.ExecuteScalar());

                            if (actividadesInscriptas >= 3)
                            {
                                MessageBox.Show("El socio ya está inscripto en 3 actividades. No puede inscribirse en más.", "Error de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }

                        // Inscribir al socio en la actividad
                        string queryInscribir = "INSERT INTO Actividad_Cliente (IdCliente, IdActividad, EsSocio) VALUES (@IdCliente, @IdActividad, 1)";
                        using (MySqlCommand cmdInscribir = new MySqlCommand(queryInscribir, conn))
                        {
                            cmdInscribir.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                            cmdInscribir.Parameters.AddWithValue("@IdActividad", this.Id);
                            cmdInscribir.ExecuteNonQuery();
                            MessageBox.Show("Socio inscrito correctamente en la actividad.", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        return true;
                    }
                    else
                    {
                        // Verificar si el cliente no socio ha pagado la actividad actual
                        string queryPagoActividad = "SELECT COUNT(*) FROM Pago_Actividad WHERE Cliente_Id = @IdCliente AND Actividad_Id = @IdActividad AND ProximoVencimiento > NOW()";
                        using (MySqlCommand cmdPagoActividad = new MySqlCommand(queryPagoActividad, conn))
                        {
                            cmdPagoActividad.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                            cmdPagoActividad.Parameters.AddWithValue("@IdActividad", this.Id);
                            int pagosValidos = Convert.ToInt32(cmdPagoActividad.ExecuteScalar());

                            if (pagosValidos == 0)
                            {
                                MessageBox.Show("El cliente no ha pagado la actividad. No puede inscribirse.", "Error de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }

                        // Inscribir al cliente no socio en la actividad
                        string queryInscribirCliente = "INSERT INTO Actividad_Cliente (IdCliente, IdActividad, EsSocio) VALUES (@IdCliente, @IdActividad, 0)";
                        using (MySqlCommand cmdInscribirCliente = new MySqlCommand(queryInscribirCliente, conn))
                        {
                            cmdInscribirCliente.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                            cmdInscribirCliente.Parameters.AddWithValue("@IdActividad", this.Id);
                            cmdInscribirCliente.ExecuteNonQuery();
                            MessageBox.Show("Cliente no socio inscrito correctamente en la actividad.", "Inscripción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al inscribir cliente en la actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

    }
}
