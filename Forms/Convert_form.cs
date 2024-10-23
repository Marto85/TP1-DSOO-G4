using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSOO_Grupo4_TP1.Datos;
using DSOO_Grupo4_TP1.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DSOO_Grupo4_TP1
{
    public partial class Convert_form : Form
    {
        private Conexion conexion;
        private Form _formularioPrincipal;

        public Convert_form(Form formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ID_Registro_Enter(object sender, EventArgs e)
        {
            if (ID_Registro.Text == "ID de cliente")
            {
                ID_Registro.Text = "";
                ID_Registro.ForeColor = Color.White;
            }

        }

        private void ID_Registro_Leave(object sender, EventArgs e)
        {
            if (ID_Registro.Text == "ID de cliente")
            {
                ID_Registro.Text = "";
                ID_Registro.ForeColor = Color.White;
            }

        }

        private void ID_Registro_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString; // Obtiene la cadena de conexión
            int id_usuario = int.Parse(ID_Registro.Text);

            if (id_usuario > 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT Nombre, Apellido, EsSocio FROM cliente WHERE Id = @id_usuario";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Definir el parámetro
                            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                            // Ejecuta la consulta y obtiene el resultado
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // Lee la primera fila del resultado
                                {
                                    string Nombre = reader.GetString("Nombre");
                                    string Apellido = reader.GetString("Apellido");
                                    byte EsSocio = reader.GetByte("EsSocio");


                                    if (EsSocio == 1)
                                    {
                                        label1.Text = $"{Nombre} {Apellido} - Socio";
                                        convert_button.Text = "Convertir en Cliente";
                                    }
                                    else
                                    {
                                        convert_button.Text = "Convertir en Socio";
                                        label1.Text = $"{Nombre} {Apellido} - No Socio";
                                    }

                                    convert_button.Visible = true;
                                }
                                else
                                {
                                    label1.Text = "No se ha encontrado el cliente con el ID indicado";
                                    convert_button.Visible = false;

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

        private void Convert_button_Click(object sender, EventArgs e)
        {
            // Obtener el ID del usuario seleccionado
            int id_usuario = int.Parse(ID_Registro.Text);

            if (id_usuario > 0)
            {
                conexion = Conexion.getInstancia();
                string connectionString = conexion.CrearConexion().ConnectionString; // Obtiene la cadena de conexión

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open(); // Abre la conexión

                        // query para obtener el valor actual de EsSocio
                        string querySelect = "SELECT EsSocio FROM cliente WHERE Id = @id_usuario";

                        using (MySqlCommand cmdSelect = new MySqlCommand(querySelect, conn))
                        {
                            cmdSelect.Parameters.AddWithValue("@id_usuario", id_usuario);

                            // Ejecuta la query para obtener el valor actual de EsSocio
                            int EsSocioActual = Convert.ToInt32(cmdSelect.ExecuteScalar());

                            // Calcula el valor inverso
                            int nuevoEsSocio = (EsSocioActual == 1) ? 0 : 1;

                            // Actualizamos el valor de EsSocio en la base de datos
                            string queryUpdate = "UPDATE cliente SET EsSocio = @nuevoEsSocio WHERE Id = @id_usuario";

                            using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@nuevoEsSocio", nuevoEsSocio);
                                cmdUpdate.Parameters.AddWithValue("@id_usuario", id_usuario);

                                // Ejecuta la actualización
                                cmdUpdate.ExecuteNonQuery();

                                if (nuevoEsSocio == 1)
                                {
                                    label1.Text = "El usuario ahora es Socio";
                                    convert_button.Text = "Convertir en Cliente";
                                }
                                else
                                {
                                    label1.Text = "El usuario ahora es No Socio";
                                    convert_button.Text = "Convertir en Socio";
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}