﻿using System;
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
            if (clientes.Any(c => c.IdCliente == idCliente))
            {
                throw new Exception("El cliente ya existe");
            }

            Socio nuevo = new Socio(idCliente, nombre, apellido, activo, esApto);
            clientes.Add(nuevo);
            return nuevo;
        }

        public NoSocio AltaNoSocio(int idCliente, string nombre, int dni, string apellido, bool activo, bool esApto)
        {
            if (clientes.Any(c => c.IdCliente == idCliente))
            {
                throw new Exception("El cliente ya existe");
            }

            NoSocio nuevo = new NoSocio(idCliente, nombre, apellido, activo, esApto);
            clientes.Add(nuevo);
            return nuevo;
        }

        public string InscribirActividad(string nombreActividad, int idCliente)
        {
            Actividad actividad = actividades.FirstOrDefault(a => a.Nombre == nombreActividad);
            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            Cliente cliente = clientes.FirstOrDefault(c => c.IdCliente == idCliente);

            if (cliente == null)
            {
                return "CLIENTE INEXISTENTE";
            }

            if (cliente is Socio && cliente.Actividades.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

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
