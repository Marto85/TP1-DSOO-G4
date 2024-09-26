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
        private List<Cliente> clientes;
        private List<Actividad> actividades;

        public ClubDeportivo()
        {
            clientes = new List<Cliente>();
            actividades = new List<Actividad>();
        }

        public ClubDeportivo(string id, string nombreUsuario, string password)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Password = password;
        }

        public List<Cliente> ObtenerMorosos()
        {
            return clientes.Where(c => !c.Activo).ToList();
        }

        public Socio AltaSocio(int idCliente, string nombre, int dni, string apellido, bool activo, bool esApto)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.IdCliente == idCliente);

            if (cliente is Socio )
            {
                throw new Exception("El Socio ya existe");
            }

            Socio nuevoSocio;

            //si ya existía como cliente, genera el socio y elimina la instancia de Cliente
            if (cliente != null)
            {
                nuevoSocio = new Socio(cliente);
                clientes.Remove(cliente);
                clientes.Add(nuevoSocio);
            }
            else {
                nuevoSocio = new Socio(idCliente, nombre, apellido, activo, esApto);
                clientes.Add(nuevoSocio);
            };

      
            return nuevoSocio;
        }

        public Cliente AltaCliente(int idCliente, string nombre, int dni, string apellido, bool activo, bool esApto)
        {
            if (clientes.Any(c => c.IdCliente == idCliente))
            {
                throw new Exception("El cliente ya existe");
            }

            Cliente nuevo = new Cliente(idCliente, nombre, apellido, activo, esApto);
            clientes.Add(nuevo);
            return nuevo;
        }

        /*
         * Permite inscribir un cliente o Socio en una actividad
         */
        public string InscribirActividad(string nombreActividad, int idCliente)
        {
            //Chequea que la actividad exista
            Actividad actividad = actividades.FirstOrDefault(a => a.Nombre == nombreActividad);
            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            //Chequea que el cliente exista
            Cliente cliente = clientes.FirstOrDefault(c => c.IdCliente == idCliente);

            if (cliente == null)
            {
                return "CLIENTE INEXISTENTE";
            }

            // Si el cliente existe y es socio, chequea la cantidad de actividades. Si no es socio, no. 
            if (cliente is Socio && cliente.Actividades.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            //Chequea si hay cupo y lo inscribe.
            if (actividad.ChequearCupo())
            {   
                cliente.Actividades.Add(actividad);
                actividad.ReservaCupo();

                return "INSCRIPCIÓN EXITOSA";
            }

            return "NO HAY CUPOS DISPONIBLES";
        }

        public List<Cliente> ObtenerClientes()
        {
            return new List<Cliente>(clientes);
        }

        public Cliente ObtenerClientePorId(int id)
        {
            return clientes.Find(c => c.IdCliente == id);
        }
    }

}
