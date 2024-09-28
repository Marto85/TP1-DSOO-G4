﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Cliente
    {
        // Campo estático para autoincrementar el IdCliente
        private static int idCounter = 1;

        public int IdCliente { get; private set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
        public bool EsApto { get; set; }

        protected List<Actividad> actividades;

        public Cliente(string nombre, string apellido, bool activo, bool esApto, int? idCliente = null)
        {
            IdCliente = idCliente ?? idCounter++;

            FechaIngreso = DateTime.Now;
            Nombre = nombre;
            Apellido = apellido;
            Activo = activo;
            EsApto = esApto;
            actividades = new List<Actividad>();
        }

        public Cliente(DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, bool activo, bool esApto, List<Actividad>? actividades = null, int? idCliente = null  )
        {
            IdCliente = idCliente ?? idCounter++;
            FechaIngreso = fechaIngreso;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            Activo = activo;
            EsApto = esApto;
            actividades = actividades ?? new List<Actividad>();
        }

        public List<Actividad> Actividades
        {
            get { return actividades; }
        }

    }

}
