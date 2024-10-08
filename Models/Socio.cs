using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Socio : Cliente
    {
        private ClubDeportivo club;
        private List<Pago> pagos;

        public Socio(string nombre, string apellido, bool activo, bool esApto, ClubDeportivo club, int? idCliente = null)
            : base(nombre, apellido, activo, esApto, idCliente)
        {
            pagos = new List<Pago>();
            this.club = club;
        }

        public Socio(string nombre, Cliente cliente, ClubDeportivo club) : base(
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
            pagos = new List<Pago>();
            this.club = club;
        }

        public void AgregarPago(Pago pago)
        {
            pagos.Add(pago);
        }

        // Método para listar todos los pagos del socio
        public void MostrarPagos(int idSocio)
        {
            //Console.WriteLine("Pagos del socio:");

            if (pagos.Count == 0)
            {
                Console.WriteLine("Este socio no tiene pagos registrados.");
            }
            else
            {
                Console.WriteLine($"El socio {Nombre} {Apellido} ha realizado los siguientes pagos:");
                foreach (var pago in pagos)
                {                
                    Console.WriteLine($"ID: {pago.Id} -- Monto: {pago.Monto} -- Fecha: {pago.FechaPago}");
                    Console.WriteLine();
                }
            }
        }
        public int ObtenerFrecuenciaDePago()
        {
            Console.WriteLine("Seleccione el periodo que desea abonar. Utilice los números para elegir la opción deseada");
            Console.WriteLine("1) Mensual");
            Console.WriteLine("2) Trimestral (5% de descuento)");
            Console.WriteLine("3) Semestral (10% de descuento)");
            Console.WriteLine("4) Anual (20% de descuento)");

            int seleccion;
            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > 4)
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione un número entre 1 y 4.");
            }

            return seleccion;
        }

        public decimal CalcularAbonoConDescuento(int frecuenciaPago)
        {
            decimal abonoConDescuento = club.ObtenerAbonoMensualSociosConDescuento(frecuenciaPago);

            switch (frecuenciaPago)
            {
                case 2:
                    return abonoConDescuento * 3; // Trimestral
                case 3:
                    return abonoConDescuento * 6; // Semestral
                case 4:
                    return abonoConDescuento * 12; // Anual
                default:
                    return abonoConDescuento; // Mensual
            }
        }

     



        /*public decimal CalcularAbonoTotalAPagar()
        {
            Console.WriteLine("Seleccione el periodo que desea abonar. Utilice los números para elegir la opción deseada");
            Console.WriteLine("1) Mensual");
            Console.WriteLine("2) Trimestral (5% de descuento)");
            Console.WriteLine("3) Semestral (10% de descuento)");
            Console.WriteLine("4) Anual (20% de descuento)");

            int seleccion;
            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > 4)
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione un número entre 1 y 4.");
            }

            decimal abonoConDescuento = club.ObtenerAbonoMensualSociosConDescuento(seleccion);

            // Dependiendo de la selección, retornar el abono con el descuento aplicado
            switch (seleccion)
            {
                case 2:
                    return abonoConDescuento * 3;
                case 3:
                    return abonoConDescuento * 6; 
                case 4:
                    return abonoConDescuento * 12; 
            }

            return abonoConDescuento; // este return cubre el caso que se seleccione mensual y evitamos poner un default que no es necesario por estar el while
        }*/
    }

}
