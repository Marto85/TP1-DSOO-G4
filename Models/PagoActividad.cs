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
        public int NoSocioId { get; set; } // Solo NoSocio
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
    }

}
