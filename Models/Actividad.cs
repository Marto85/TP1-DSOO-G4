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

    }
}
