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

        public enum FrecuenciaPago
        {
            Mensual = 1,
            Trimestral = 3,
            Semestral = 6,
            Anual = 12
        }

        public Pago(int socioId, decimal monto, DateTime fechaPago, FrecuenciaPago frecuencia)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto del pago debe ser mayor a 0");
            }

            SocioId = socioId;
            Monto = monto;
            FechaPago = fechaPago;
            ProximoVencimiento = fechaPago.AddMonths((int)frecuencia); // Calcular próximo vencimiento basado en frecuencia
        }


        public DateTime CalcularProximoVencimiento()
        {
           return ProximoVencimiento;
        }
    }
}
