using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class ClubDeportivo
    {
        public string Id { get; set; }
        public string NombreUsuario { get; set; }

        private string Password;
        private decimal abonoMensualSocios = 5000; // abono inicial socios
        private List<Cliente> clientes;
        private List<Actividad> actividades;

        public ClubDeportivo()
        {
            clientes = new List<Cliente>();
            actividades = new List<Actividad>
            {
                new Actividad(1, "Yoga", "Clase de yoga para todos los niveles", 500, "Lunes 18:00", 10, "Ana López"),
                new Actividad(2, "Pilates", "Pilates intermedio", 600, "Martes 17:00", 8, "Carlos Pérez"),
                new Actividad(3, "Zumba", "Clase de zumba energizante", 400, "Miércoles 19:00", 12, "María Gómez"),
                new Actividad(4, "Crossfit", "Entrenamiento de alta intensidad", 700, "Jueves 18:00", 5, "Juan Martínez"),
                new Actividad(5, "Natacion", "Clase de natación", 800, "Viernes 17:00", 6, "Lucía Fernández"),
                new Actividad(6, "Futbol", "Partido de fútbol amistoso", 300, "Sábado 16:00", 20, "Pedro González")
            };
        }

        public ClubDeportivo(string id, string nombreUsuario, string password)
            : this() // llamada al constructor anterior para que aca tambien inicialice listas
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Password = password;
        }

        public decimal ObtenerAbonoMensualSociosBase()
        {
            return abonoMensualSocios;
        }   

        public void ModificarAbonoMensualSocios(decimal nuevoAbono)
        {
            abonoMensualSocios = nuevoAbono;
        }

        public decimal ObtenerAbonoMensualSociosConDescuento(int frecuenciaPago)
        {
            switch (frecuenciaPago)
            {
                case 1:
                    return abonoMensualSocios;
                case 2:
                    return abonoMensualSocios * 0.95m;
                case 3:
                    return abonoMensualSocios * 0.85m;
                case 4:
                    return abonoMensualSocios  * 0.75m;
                default:
                    return abonoMensualSocios;
            }
        }        

       

        /*public Socio AltaSocio(string nombre, string apellido, int dni, bool activo, bool esApto)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.DNI == dni);
            if (cliente == null)
            {
                // Si no existe como cliente, creamos un socio desde cero
                Socio nuevoSocio = new Socio(nombre, apellido, activo, esApto, this);
                clientes.Add(nuevoSocio);
                return nuevoSocio;
            }
            else {
                ConvertirEnSocio(cliente);
                return (Socio)cliente;
            }
        }*/

        /*public void ConvertirEnSocio(Cliente cliente)
        {
            if (cliente is Socio)
            {
                Console.WriteLine("El cliente ya es un socio.");
                return;
            }

            // Convertir el cliente en socio
            Socio nuevoSocio = new Socio (cliente.Nombre, cliente.Apellido, true, true, this, cliente.IdCliente);
            clientes.Remove(cliente);  // Eliminar el cliente original
            clientes.Add(nuevoSocio);  // Añadir el nuevo socio

            // Verificar si el cliente tiene más de 3 actividades inscritas
            if (nuevoSocio.Actividades.Count > 3)
            {
                Console.WriteLine($"El cliente tiene {nuevoSocio.Actividades.Count} actividades inscritas. Solo puede tener 3.");

                while (nuevoSocio.Actividades.Count > 3)
                {
                    Console.WriteLine("Actividades actuales inscritas:");
                    for (int i = 0; i < nuevoSocio.Actividades.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {nuevoSocio.Actividades[i].Nombre}");
                    }

                    Console.WriteLine("Indica el número de la actividad que deseas dar de baja:");
                    int seleccion;
                    if (int.TryParse(Console.ReadLine(), out seleccion) && seleccion > 0 && seleccion <= nuevoSocio.Actividades.Count)
                    {
                        // Remover la actividad seleccionada
                        nuevoSocio.Actividades.RemoveAt(seleccion - 1);
                        Console.WriteLine("Actividad eliminada.");
                    }
                    else
                    {
                        Console.WriteLine("Selección no válida. Intenta nuevamente.");
                    }
                }
            }

            Console.WriteLine("Cliente convertido a socio exitosamente.");
        }*/

        /*
         * Permite inscribir un cliente o Socio en una actividad
         */
        /*public string InscribirActividad(string nombreActividad, int idCliente)
        {
            //Chequea que la actividad exista
            Actividad actividad = actividades.FirstOrDefault(a => a.Nombre == nombreActividad);            
            if (actividad == null) return "ACTIVIDAD INEXISTENTE";

            //Chequea que el cliente exista
            Cliente cliente = clientes.FirstOrDefault(c => c.IdCliente == idCliente);
            if (cliente == null) return "CLIENTE INEXISTENTE";


            // Verificar si el cliente ya está inscrito en la actividad
            if (cliente.Actividades.Any(a => a.Nombre == nombreActividad))
            {
                return "EL CLIENTE YA ESTÁ INSCRITO EN ESTA ACTIVIDAD";
            }

            // Si el cliente existe y es socio, chequea la cantidad de actividades. Si no es socio, no. 
            if (cliente is Socio && cliente.Actividades.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            // Chequear si hay cupo en la actividad
            if (!actividad.ChequearCupo())
            {
                return "NO HAY CUPOS DISPONIBLES";
            }

            // Registrar inscripción y restar cupo
            cliente.Actividades.Add(actividad);
            actividad.ReservaCupo();
            actividad.AgregarInscripto(cliente); // Método para agregar el cliente a la lista de inscriptos de la actividad

            // Verificar que se agrego la actividad
            if (cliente.Actividades.Contains(actividad))
            {
                Console.WriteLine($"El cliente {cliente.Nombre} ha sido inscrito correctamente en la actividad {actividad.Nombre}.");
            }
            else
            {
                Console.WriteLine("Hubo un error al inscribir al cliente en la actividad.");
            }

            return "INSCRIPCIÓN EXITOSA";
        }*/

        public List<Actividad> ObtenerActividades()
        {
            return actividades;
        }
        public List<Cliente> ObtenerClientesFiltrados(bool soloSocios = false, bool soloNoSocios = false)
        {
            if(soloSocios && !soloNoSocios) return clientes.Where(c => c is Socio).ToList();

            else if (soloNoSocios && !soloSocios) return clientes.Where(c => !(c is Socio)).ToList();

            else return clientes.ToList();
        }

        public Cliente ObtenerClientePorId(int id)
        {
            return clientes.Find(c => c.IdCliente == id);
        }

        public List<Cliente> ObtenerMorosos()
        {
            return clientes.Where(c => !c.Activo).ToList();
        }

        /*public void ProcesarPago(int idSocio)
        {
            Socio SocioPagador = clientes.FirstOrDefault(c => c.IdCliente == idSocio) as Socio;
            if (SocioPagador == null)
            {
                throw new Exception("El socio no existe o no es un socio.");
            }

            else if (SocioPagador.Activo == true)
            {
                Console.WriteLine("Su cuota se encuentra al dia");
            }
            else
            {
                Console.WriteLine("Vamos a procesar tu pago");
                int frecuenciaPago = SocioPagador.ObtenerFrecuenciaDePago();
                
                // Convertimos el int previo en el valor correspondiente del enum FrecuenciaPago (de la clase Pago)
                Pago.FrecuenciaPago frecuencia = (Pago.FrecuenciaPago)frecuenciaPago;
                Console.WriteLine($"La frecuencia elegida es: {frecuencia}");
                
                decimal montoTotalAbonado = SocioPagador.CalcularAbonoConDescuento(frecuenciaPago);
                SocioPagador.Activo = true;
                Pago nuevoPago = new Pago(idSocio, montoTotalAbonado, DateTime.Now, frecuencia);
                SocioPagador.AgregarPago(nuevoPago);
                Console.WriteLine();
                Console.WriteLine("Tu pago se ha procesado con exito");
                SocioPagador.MostrarPagos(SocioPagador.IdCliente);
                DateTime proximoVencimiento = nuevoPago.CalcularProximoVencimiento();
                Console.WriteLine($"Su abono estara vigente hasta el dia: {proximoVencimiento}");
            }
        }*/
    }
}
