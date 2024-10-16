using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DSOO_Grupo4_TP1.Forms
{
    public partial class Inscribir_Actividades_Form : Form
    {
        private Conexion conexion;
        public Inscribir_Actividades_Form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                        conn.Open(); // Abre la conexión
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
                                        label1.Text = $"{Nombre} {Apellido} - es socio con abono. Puede inscribirse hasta en 3 actividades diferentes.";
                                    }
                                    else
                                    {
                                        label1.Text = $"{Nombre} {Apellido} - Paga por actividades individuales";
                                    }
                                   
                                }
                                else
                                {
                                    label1.Text = "No se ha encontrado el cliente con el ID indicado";
                                    //convert_button.Visible = false;

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        Console.WriteLine("Error en la conexión: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close(); // Cierra la conexión
                    }
                }
            }
            
        }
    }
}
