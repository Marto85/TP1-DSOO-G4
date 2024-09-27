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
            : this() // llamada al constructor anterior para que aca tambien inicialice listas
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Password = password;
        }

        public Cliente AltaCliente(string nombre, string apellido, int dni, bool activo, bool esApto)
        {
            if (clientes.Any(c => c.DNI == dni))
            {
                throw new Exception("El cliente ya existe");
            }

            Cliente nuevo = new Cliente(nombre, apellido, activo, esApto);
            clientes.Add(nuevo);
            return nuevo;
        }

        public Socio AltaSocio(string nombre, string apellido, int dni, bool activo, bool esApto)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.DNI == dni);
            if (cliente == null)
            {
                // Si no existe como cliente, creamos un socio desde cero
                Socio nuevoSocio = new Socio(nombre, apellido, activo, esApto);
                clientes.Add(nuevoSocio);
                return nuevoSocio;
            }
            else {
                return ConvertirEnSocio(cliente.IdCliente);
            }
        }

        /*
        * Convierte un cliente existente en socio
        */

        public Socio ConvertirEnSocio(int idCliente)
        {
            Cliente cliente = clientes.FirstOrDefault(c => c.IdCliente == idCliente);

            if (cliente is Socio)
            {
                throw new Exception("El cliente ya es un socio.");
            }

            if (cliente == null)
            {
                throw new Exception("El cliente no existe.");
            }

            clientes.Remove(cliente);
            Socio nuevoSocio = new Socio(cliente);
            clientes.Add(nuevoSocio);

            return nuevoSocio;
        }


        /*
         * Permite inscribir un cliente o Socio en una actividad
         */
        public string InscribirActividad(string nombreActividad, int idCliente)
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

            //Chequea si hay cupo y lo inscribe.
            if (actividad.ChequearCupo())
            {   
                cliente.Actividades.Add(actividad);
                actividad.ReservaCupo();

                return "INSCRIPCIÓN EXITOSA";
            }

            return "NO HAY CUPOS DISPONIBLES";
        }

        /*public List<Cliente> ObtenerClientes()
        {
            return new List<Cliente>(clientes);
        }*/

        public List<Cliente> ObtenerClientesFiltrados(bool soloSocios = false, bool soloNoSocios = false)
        {
            if(soloSocios) return clientes.Where(c => c is Socio).ToList();

            else if (soloNoSocios) return clientes.Where(c => !(c is Socio)).ToList();

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
    }

}
