using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;


namespace DSOO_Grupo4_TP1.Datos
{
    public class Conexion // la clase debe ser PUBLICA
    {
        // Declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion() // Constructor privado
        {
            // Inicializamos las variables con valores por defecto
            this.baseDatos = "clubdeportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";
        }

        // Método para crear la conexión
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;

                // Intentar abrir la conexión
                cadena.Open();
            }
            catch (Exception ex)
            {
                cadena = null;
                MessageBox.Show("Error al conectar: " + ex.Message);
                throw;
            }
            cadena.Close();
            return cadena;
        }

        // Método para evaluar la instancia de la conectividad
        public static Conexion? getInstancia()
        {
            if (con == null) // Si no hay una conexión existente
            {
                con = new Conexion(); // Crear una nueva instancia

                bool conexionExitosa = false;

                while (!conexionExitosa)
                {
                    // Pedir datos al usuario a través de InputBox
                    string Tservidor = Prompt.ShowDialog("Ingrese el servidor:", "Conexión a Base de Datos");
                    string Tpuerto = Prompt.ShowDialog("Ingrese el puerto:", "Conexión a Base de Datos");
                    string Tusuario = Prompt.ShowDialog("Ingrese el usuario:", "Conexión a Base de Datos");
                    string Tclave = Prompt.ShowDialog("Ingrese la clave:", "Conexión a Base de Datos");
                    string TbaseDatos = Prompt.ShowDialog("Ingrese el nombre de la base de datos:", "Conexión a Base de Datos");

                    // Asignar los valores ingresados
                    con.servidor = Tservidor;
                    con.puerto = Tpuerto;
                    con.usuario = Tusuario;
                    con.clave = Tclave;
                    con.baseDatos = TbaseDatos;

                    // Intentar crear la conexión
                    try
                    {
                        using (var connection = con.CrearConexion())
                        {
                            MessageBox.Show("Conexión exitosa");
                            conexionExitosa = true; // Salir del ciclo si la conexión es exitosa
                        }
                    }
                    catch
                    {
                        DialogResult resultado = MessageBox.Show("Los datos ingresados son incorrectos. ¿Desea intentar nuevamente?",
                                                                  "Error de Conexión",
                                                                  MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.No)
                        {
                            return null;
                            //break; // Salir del ciclo si el usuario no quiere intentar nuevamente
                        }
                    }
                }
            }

            return con;
        }


        // Clase auxiliar para mostrar un InputBox
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 800, // Aumentar el ancho del formulario
                    Height = 400, // Aumentar la altura del formulario
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label()
                {
                    Left = 50,
                    Top = 20,
                    Text = text,
                    AutoSize = true, // Ajustar automáticamente el tamaño del label
                    Font = new Font("Arial", 12) // Cambiar la fuente y tamaño del texto
                };

                TextBox textBox = new TextBox()
                {
                    Left = 50,
                    Top = 60,
                    Width = 400, // Aumentar el ancho del TextBox
                    Font = new Font("Arial", 12) // Cambiar la fuente y tamaño del texto
                };

                Button confirmation = new Button()
                {
                    Text = "Aceptar",
                    Left = 200, // Centrar el botón horizontalmente
                    Width = 180, // Aumentar el ancho del botón
                    Height = 50,
                    Top = 120,
                    Font = new Font("Arial", 12) // Cambiar la fuente y tamaño del texto
                };

                confirmation.Click += (sender, e) => { prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);

                prompt.ShowDialog();

                return textBox.Text;
            }

        }
    }
}