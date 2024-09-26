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
        public decimal PrecioNoSocio { get; private set; }
        public string Horario { get; private set; }
        public int CuposDisponibles { get; private set; }
        public string Profesor { get; set; }

        public Actividad(int id, string nombre, string descripcion, decimal precioNoSocio, string horario, int cuposDisponibles, string profesor)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioNoSocio = precioNoSocio;
            Horario = horario;
            CuposDisponibles = cuposDisponibles;
            Profesor = profesor;
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
    }

}
