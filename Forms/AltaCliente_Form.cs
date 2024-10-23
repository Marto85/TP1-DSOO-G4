using DSOO_Grupo4_TP1.Datos;
using DSOO_Grupo4_TP1.Forms;
using DSOO_Grupo4_TP1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_Grupo4_TP1
{
    public partial class AltaCliente_Form : Form
    {
        private Form _formularioPrincipal;
        private string? imgPath;

        public AltaCliente_Form(Form formularioPrincipal)
        {
            InitializeComponent();
            _formularioPrincipal = formularioPrincipal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Mail_Registro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tipo_Cliente_Form_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Enviar_Registro_Click(object sender, EventArgs e)
        {
            DateTime fechaIngreso = DateTime.Now;
            string nombre = Nombre_Registro.Text;
            string apellido = Apellido_Registro.Text;
            int dni = int.Parse(DNI_Registro.Text);
            string domicilio = Domicilio_Registro.Text;
            string telefono = Telefono_Registro.Text;
            string mail = Mail_Registro.Text;
            bool esSocio = Socio.Checked;
            string? imagenPerfil = imgPath;

            Cliente nuevoCliente = new Cliente(fechaIngreso, nombre, apellido, dni, domicilio, telefono, mail, imagenPerfil, esSocio);
            nuevoCliente.AltaCliente();
            GenerarCarnet(nuevoCliente.IdCliente);

            //nuevoCliente.ImprimirCarnet(nuevoCliente);

            this.Close();

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_Registro_TextChanged(object sender, EventArgs e)
        {

        }


        private void Nombre_Registro_Enter(object sender, EventArgs e)
        {
            if (Nombre_Registro.Text == "Nombre")
            {
                Nombre_Registro.Text = "";
                Nombre_Registro.ForeColor = Color.White;
            }
        }

        private void Nombre_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre_Registro.Text))
            {
                Nombre_Registro.Text = "Nombre";
                Nombre_Registro.ForeColor = Color.DarkGray;
            }
        }

        private void Apellido_Registro_Enter(object sender, EventArgs e)
        {
            if (Apellido_Registro.Text == "Apellido")
            {
                Apellido_Registro.Text = "";
                Apellido_Registro.ForeColor = Color.White;
            }
        }

        private void Apellido_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Apellido_Registro.Text))
            {
                Apellido_Registro.Text = "Apellido";
                Apellido_Registro.ForeColor = Color.DarkGray;
            }
        }

        private void DNI_Registro_Enter(object sender, EventArgs e)
        {
            if (DNI_Registro.Text == "DNI")
            {
                DNI_Registro.Text = "";
                DNI_Registro.ForeColor = Color.White;
            }
        }

        private void DNI_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DNI_Registro.Text))
            {
                DNI_Registro.Text = "DNI";
                DNI_Registro.ForeColor = Color.DarkGray;
            }
        }

        private void Telefono_Registro_Enter(object sender, EventArgs e)
        {
            if (Telefono_Registro.Text == "Telefono")
            {
                Telefono_Registro.Text = "";
                Telefono_Registro.ForeColor = Color.White;
            }
        }

        private void Telefono_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Telefono_Registro.Text))
            {
                Telefono_Registro.Text = "Telefono";
                Telefono_Registro.ForeColor = Color.DarkGray;
            }
        }

        private void Domicilio_Registro_Enter(object sender, EventArgs e)
        {
            if (Domicilio_Registro.Text == "Domicilio")
            {
                Domicilio_Registro.Text = "";
                Domicilio_Registro.ForeColor = Color.White;
            }
        }

        private void Domicilio_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Domicilio_Registro.Text))
            {
                Domicilio_Registro.Text = "Domicilio";
                Domicilio_Registro.ForeColor = Color.DarkGray;
            }
        }

        private void Mail_Registro_Enter(object sender, EventArgs e)
        {
            if (Mail_Registro.Text == "Correo Electronico")
            {
                Mail_Registro.Text = "";
                Mail_Registro.ForeColor = Color.White;
            }
        }

        private void Mail_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Mail_Registro.Text))
            {
                Mail_Registro.Text = "Correo Electronico";
                Mail_Registro.ForeColor = Color.DarkGray;
            }
        }

        private void AltaCliente_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Enviar_Registro_Click(sender, e);
                e.Handled = true;
            }
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

        private void ImagenPerfil_Click(object sender, EventArgs e)
        {
            Form formulario = new Foto_form(this);
            formulario.ShowDialog();
        }

        public void AsignarImagenPerfil(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                imgPath = imagePath;
                ImagenPerfil.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("La imagen no se encontró.");
            }
        }

        private void Capturar_foto_Click(object sender, EventArgs e)
        {
            Form formulario = new Foto_form(this);
            formulario.ShowDialog();
        }

        private void GenerarCarnet(int clienteId)
        {
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT Nombre, Apellido, DNI, Imagen_Perfil, EsSocio FROM Cliente WHERE Id = @Id", conn
                    );
                    cmd.Parameters.AddWithValue("@Id", clienteId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader.GetString("Nombre");
                            string apellido = reader.GetString("Apellido");
                            int dni = reader.GetInt32("DNI");
                            string imagenPerfil = reader["Imagen_Perfil"] != DBNull.Value ? reader.GetString("Imagen_Perfil") : null;
                            bool esSocio = reader.GetBoolean("EsSocio");

                            Carnet_Form formularioCarnet = new Carnet_Form();

                            formularioCarnet.SetDatosCliente(nombre, apellido, dni, imagenPerfil, esSocio);

                            formularioCarnet.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para el cliente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al recuperar los datos: {ex.Message}");
                }
            }
        }

    }
}