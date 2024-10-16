using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Pago
    {
        public int Id { get; private set; }
        public int SocioId { get; private set; }
        public decimal Monto { get; private set; }
        public DateTime FechaPago { get; private set; }
        public DateTime ProximoVencimiento { get; private set; }

   

        /*public Pago(int socioId, decimal monto, DateTime fechaPago, FrecuenciaPago frecuencia)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto del pago debe ser mayor a 0");
            }

            SocioId = socioId;
            Monto = monto;
            FechaPago = fechaPago;
            ProximoVencimiento = fechaPago.AddMonths((int)frecuencia); // Calcular próximo vencimiento basado en frecuencia
        }*/


        public DateTime CalcularProximoVencimiento()
        {
           return ProximoVencimiento;
        }

        public bool VerificarPagoSocio(int idCliente)
        {
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();

                    // Consulta SQL que verifica si el cliente tiene pagos al día
                    string query = "SELECT COUNT(*) FROM Pago WHERE Cliente_Id = @IdCliente AND ProximoVencimiento > NOW()";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Parámetro de la consulta
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);

                        // Ejecutar la consulta y obtener el resultado
                        int pagosValidos = Convert.ToInt32(cmd.ExecuteScalar());

                        // Si hay al menos un pago válido, el socio está al día
                        return pagosValidos > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al verificar pago del socio: " + ex.Message);
                    return false;
                }
            }
        }



    }
}
