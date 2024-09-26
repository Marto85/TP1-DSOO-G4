using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Socio : Cliente
    {
        public Socio(int idCliente, string nombre, string apellido, bool activo, bool esApto)
            : base(idCliente, nombre, apellido, activo, esApto)
        {
        }

    }

}
