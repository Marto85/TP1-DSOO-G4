using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Socio : Cliente
    {
        public List<Pago> Pagos { get; private set; }

        /*public Socio(string nombre, string apellido, string domicilio, bool activo, bool esApto)
            : base(nombre, apellido, domicilio, activo, esApto)
        {
            Pagos = new List<Pago>();
        }*/

        public Socio(DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, bool activo = true, bool esApto = true)
            : base(fechaIngreso, nombre, apellido, dni, direccion, telefono, email, activo, esApto)
        {
            Pagos = new List<Pago>();
        }

        // Método para agregar un pago a la base de datos
        public void AgregarPago(Pago pago)
        {
            Pagos.Add(pago);
            // Guardar el pago en la base de datos
        }

        public List<Pago> ObtenerPagos()
        {
            // Recuperar pagos desde la base de datos
            return Pagos;
        }
    }

}
