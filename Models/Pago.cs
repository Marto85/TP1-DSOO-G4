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
        public int SocioId { get; private set; } // Cambiado a SocioId
        public decimal Monto { get; private set; }
        public DateTime FechaPago { get; private set; }
        public DateTime ProximoVencimiento { get; private set; }
        public int Cuotas { get; private set; }

        public Pago(int id, int socioId, decimal monto, DateTime fechaPago, int cuotas)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto del pago debe ser mayor a 0");
            }
            if (cuotas <= 0)
            {
                throw new ArgumentException("La cantidad de cuotas debe ser mayor a 0");
            }

            Id = id;
            SocioId = socioId;
            Monto = monto;
            FechaPago = fechaPago;
            ProximoVencimiento = fechaPago.AddMonths(cuotas);
            Cuotas = cuotas;
        }

        public void CalcularProximoVencimiento()
        {
            ProximoVencimiento = FechaPago.AddMonths(Cuotas);
        }
    }


}
