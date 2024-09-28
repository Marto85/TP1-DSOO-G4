using DSOO_Grupo4_TP1.Models;

namespace DSOO_Grupo4_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClubDeportivo club = new ClubDeportivo();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("==== MENÚ PRINCIPAL ====");
                Console.WriteLine("1) Dar de alta un cliente");
                Console.WriteLine("2) Dar de alta un socio");
                Console.WriteLine("3) Convertir cliente en socio");
                Console.WriteLine("4) Inscribirse en una actividad");
                Console.WriteLine("5) Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Alta de cliente
                        Console.Write("Ingrese Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese Apellido: ");
                        string apellido = Console.ReadLine();
                        Console.Write("Ingrese DNI: ");
                        int dni = int.Parse(Console.ReadLine());
                        Cliente nuevoCliente = club.AltaCliente(nombre, apellido, dni, true, true);
                        Console.WriteLine($"Cliente {nuevoCliente.Nombre} {nuevoCliente.Apellido} dado de alta.");
                        Console.WriteLine("Actualmente la lista de clientes es la siguiente: ");
                        List<Cliente> clientesF = club.ObtenerClientesFiltrados(soloNoSocios: true);

                        foreach (Cliente cliente in clientesF)
                        {
                            Console.WriteLine($"ID: {cliente.IdCliente} - {cliente.Nombre} {cliente.Apellido}");
                        }
                        break;

                    case "2":
                        // Alta de socio
                        Console.Write("Ingrese Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese Apellido: ");
                        apellido = Console.ReadLine();
                        Console.Write("Ingrese DNI: ");
                        dni = int.Parse(Console.ReadLine());
                        Socio nuevoSocio = club.AltaSocio(nombre, apellido, dni, true, true);
                        Console.WriteLine($"Socio {nuevoSocio.Nombre} dado de alta.");
                        Console.WriteLine("Actualmente la lista de Socios es la siguiente: ");
                        List<Cliente> socios = club.ObtenerClientesFiltrados(soloSocios: true);
                        

                        foreach (Cliente socio in socios)
                        {
                            Console.WriteLine($"ID: {socio.IdCliente} - {socio.Nombre} {socio.Apellido}");
                        }
                        break;

                    case "3":
                        // Convertir cliente en socio
                        Console.Write("Ingrese ID del cliente a convertir: ");
                        int idCliente = int.Parse(Console.ReadLine());

                        try
                        {
                            // Buscar el cliente por ID
                            Cliente cliente = club.ObtenerClientePorId(idCliente);

                            // Verificar que el cliente exista
                            if (cliente == null)
                            {
                                Console.WriteLine("El cliente no existe.");
                            }
                            else
                            {
                                // Convertir el cliente en socio
                                club.ConvertirEnSocio(cliente);
                                Console.WriteLine($"Cliente {cliente.Nombre} convertido en socio.");
                                Console.WriteLine("Actualmente la lista de socios es la siguiente: ");
                                List<Cliente> socioExCliente = club.ObtenerClientesFiltrados(soloSocios: true);
                                foreach (Cliente socio in socioExCliente)
                                {
                                    Console.WriteLine($"ID: {socio.IdCliente} - {socio.Nombre} {socio.Apellido}");
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;


                    case "4":
                        // Inscribir en actividad
                        Console.Write("Ingrese ID Cliente: ");
                        idCliente = int.Parse(Console.ReadLine());

                        Cliente clienteCheck = club.ObtenerClientesFiltrados(true, true).FirstOrDefault(c => c.IdCliente == idCliente);
                        if (clienteCheck == null) { Console.Write("El id ingresado no corresponde a ningún cliente o socio. "); break;  }

                        Console.Write("Ingrese nombre de la actividad: ");
                        string actividad = Console.ReadLine();
                        string resultado = club.InscribirActividad(actividad, idCliente);
                        Console.WriteLine(resultado);
                        break;

                    case "5":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
    
}
