using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Socio : Cliente
    {
        public Socio(string nombre, string apellido, bool activo, bool esApto, int? idCliente = null)
            : base(nombre, apellido, activo, esApto, idCliente)
        {
        }

        public Socio(Cliente cliente) : base(
          cliente.FechaIngreso,
          cliente.Nombre,
          cliente.Apellido,
          cliente.DNI,
          cliente.Direccion,
          cliente.Telefono,
          cliente.Email,
          cliente.FechaNacimiento,
          cliente.Activo,
          cliente.EsApto,
          cliente.Actividades,
          cliente.IdCliente)
        {
        }
    }

}
