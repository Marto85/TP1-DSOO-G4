using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class NoSocio : Cliente
    {
        public NoSocio(int idCliente, string nombre, string apellido, bool activo, bool esApto)
            : base(idCliente, nombre, apellido, activo, esApto)
        {
        }

        public NoSocio(int idCliente, DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, bool activo, bool esApto)
            : base(idCliente, fechaIngreso, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, activo, esApto)
        {
        }

    }

}
