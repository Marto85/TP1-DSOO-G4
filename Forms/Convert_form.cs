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
        private Cliente cliente;

        public Convert_form(Form formularioPrincipal)
        {
            InitializeComponent();
            this.AcceptButton = Buscar_Cliente;
            _formularioPrincipal = formularioPrincipal;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ID_Registro_Enter(object sender, EventArgs e)
        {
            if (ID_Registro.Text == "DNI de cliente")
            {
                ID_Registro.Text = "";
                ID_Registro.ForeColor = Color.White;
            }
        }

        private void ID_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID_Registro.Text))
            {
                ID_Registro.Text = "DNI de cliente";
                ID_Registro.ForeColor = Color.DarkGray;
            }
        }

        private void Btn_search(object sender, EventArgs e)
        {
          
            int dni_usuario = int.Parse(ID_Registro.Text);

            if (dni_usuario > 0)
            {
                cliente = new Cliente(dni_usuario);
              
                if (cliente.EsSocio)
                {
                    label1.Text = $"{cliente.Nombre} {cliente.Apellido} - Socio";
                    convert_button.Text = "Convertir en Cliente";
                }
                else
                {
                    convert_button.Text = "Convertir en Socio";
                    label1.Text = $"{cliente.Nombre} {cliente.Apellido} - No Socio";
                }

                convert_button.Visible = true;
            }
            else
            {
                label1.Text = "No se ha encontrado el cliente con el ID indicado";
                convert_button.Visible = false;

            }
         
        }
    


        private void Convert_button_Click(object sender, EventArgs e)
        {
            // Obtener el ID del usuario seleccionado
            int dni_usuario = int.Parse(ID_Registro.Text);

            if (dni_usuario > 0)
            {
                conexion = Conexion.getInstancia();
                string connectionString = conexion.CrearConexion().ConnectionString; // Obtiene la cadena de conexión

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open(); // Abre la conexión

                        // query para obtener el valor actual de EsSocio
                        string querySelect = "SELECT EsSocio FROM cliente WHERE DNI = @dni_usuario";

                        using (MySqlCommand cmdSelect = new MySqlCommand(querySelect, conn))
                        {
                            cmdSelect.Parameters.AddWithValue("@dni_usuario", dni_usuario);

                            // Ejecuta la query para obtener el valor actual de EsSocio
                            int EsSocioActual = Convert.ToInt32(cmdSelect.ExecuteScalar());

                            // Calcula el valor inverso
                            int nuevoEsSocio = (EsSocioActual == 1) ? 0 : 1;
                            string queryUpdate = "";

                            // Actualizamos el valor de EsSocio en la base de datos
                            if (nuevoEsSocio == 0)
                            {
                                queryUpdate = "UPDATE cliente SET EsSocio = @nuevoEsSocio, AbonoMensualSocios = NULL WHERE DNI = @dni_usuario";
                            }
                            else {
                                queryUpdate = "UPDATE cliente SET EsSocio = @nuevoEsSocio, AbonoMensualSocios = 10000 WHERE DNI = @dni_usuario";

                            }

                            using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@nuevoEsSocio", nuevoEsSocio);
                                cmdUpdate.Parameters.AddWithValue("@dni_usuario", dni_usuario);

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

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
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

        private void Convert_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}