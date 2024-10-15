﻿using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Cliente
    {
        public int IdCliente { get; private set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool EsSocio { get; set; }
        public bool EsApto { get; set; }


        public Cliente(DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, bool esSocio = false, bool esApto = true)
        {
            FechaIngreso = fechaIngreso;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            EsSocio = esSocio;
            EsApto = esApto;
        }

        public void AltaCliente()
        {
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO cliente 
                     (FechaIngreso, Nombre, Apellido, DNI, Direccion, Telefono, Email, EsSocio, EsApto) 
                     VALUES (@fechaIngreso, @nombre, @apellido, @dni, @direccion, @telefono, @email, @esSocio, @esApto)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@dni", DNI);
                        cmd.Parameters.AddWithValue("@direccion", Direccion);
                        cmd.Parameters.AddWithValue("@telefono", Telefono);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@esSocio", EsSocio);
                        cmd.Parameters.AddWithValue("@esApto", EsApto);
                        cmd.Parameters.AddWithValue("@fechaIngreso", FechaIngreso);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show($"Se procede a entregar al socio numero {IdCliente + 1} con nombre {Nombre} {Apellido} el carnet que lo acredita como socio de Club Sports");
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al registrar cliente: {ex.Message}\nCódigo del error: {ex.Number}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar cliente: " + ex.Message);
                }

            }
        }

    }

}
