using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class PagoActividad
    {
        public int Id { get; set; }
        public int NoSocioId { get; set; }
        public int ActividadId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public DateTime ProximoVencimiento { get; private set; }

        public PagoActividad(int idPagoActividad, int noSocioId, int actividadId, decimal monto, DateTime fechaPago, int duracionDias)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto debe ser mayor a 0");
            }
            if (duracionDias <= 0)
            {
                throw new ArgumentException("La duracion de la actividad debe ser mayor a 0");
            }

            Id = idPagoActividad;
            NoSocioId = noSocioId;
            ActividadId = actividadId;
            Monto = monto;
            FechaPago = fechaPago;
            ProximoVencimiento = fechaPago.AddDays(duracionDias);
        }

        public bool VerificaPagoCliente()
        {
            Conexion conexion = Conexion.getInstancia();
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                // Verificar si el cliente no socio ha pagado la actividad actual
                string queryPagoActividad = "SELECT COUNT(*) FROM Pago_Actividad WHERE Cliente_Id = @IdCliente AND Actividad_Id = @IdActividad AND ProximoVencimiento > NOW()";
                using (MySqlCommand cmdPagoActividad = new MySqlCommand(queryPagoActividad, conn))
                {
                    //cmdPagoActividad.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    cmdPagoActividad.Parameters.AddWithValue("@IdActividad", this.Id);
                    int pagosValidos = Convert.ToInt32(cmdPagoActividad.ExecuteScalar());

                    if (pagosValidos == 0)
                    {
                        MessageBox.Show("El cliente no ha pagado la actividad. No puede inscribirse.", "Error de inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
