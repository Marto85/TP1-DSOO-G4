using DSOO_Grupo4_TP1.Datos;
using DSOO_Grupo4_TP1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_Grupo4_TP1.Forms
{
    public partial class Pago_Form : Form
    {
        private Cliente clienteActual;
        private Conexion conexion;
        public Pago_Form()
        {
            InitializeComponent();
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            Form menuForm = Application.OpenForms["Menu_Form"];
            if (menuForm != null)
            {
                menuForm.Show();
            }

            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void Buscar_Cliente_Click(object sender, EventArgs e)
        {
            conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString; // Obtiene la cadena de conexión
            int dni_usuario = int.Parse(DNI_Pagos.Text);

            if (dni_usuario > 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT Nombre, Apellido, EsSocio FROM cliente WHERE DNI = @dni_usuario";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Definir el parámetro
                            cmd.Parameters.AddWithValue("@dni_usuario", dni_usuario);

                            // Ejecuta la consulta y obtiene el resultado
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // Lee la primera fila del resultado
                                {
                                    string nombre = reader.GetString("Nombre");
                                    string apellido = reader.GetString("Apellido");
                                    int dni = reader.GetInt32("DNI");
                                    string direccion = reader.GetString("Direccion");
                                    string telefono = reader.GetString("Telefono");
                                    string email = reader.GetString("Email");
                                    bool esSocio = reader.GetBoolean("EsSocio");
                                    string imagenPerfil = reader.GetString("ImagenPerfil");

                                    clienteActual = new Cliente(DateTime.Now, nombre, apellido, dni, direccion, telefono, email, imagenPerfil, esSocio : esSocio);

                                    Txt_Nombre.Text = nombre;
                                    Txt_Apellido.Text = apellido;
                                    Txt_EsSocio.Text = esSocio ? "SI" : "NO";
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún cliente con el DNI proporcionado.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error en la conexión: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
