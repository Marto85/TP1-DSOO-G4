using DSOO_Grupo4_TP1.Forms;
using DSOO_Grupo4_TP1.Models;
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
        private string imgPath;
        private Cliente clienteAImprimir;

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
            bool esApto = true;
            string imagenPerfil = imgPath;

            Cliente nuevoCliente = new Cliente(fechaIngreso, nombre, apellido, dni, domicilio, telefono, mail, imagenPerfil, esSocio);
            nuevoCliente.AltaCliente();
            

            //ENVIA IMPRESION - FALTA REVISAR SI PETICIÓN SQL FUE SATISFACTORIA
            clienteAImprimir = nuevoCliente;
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPageHandler); // Vincula el evento de impresión

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print(); // Enviar directamente a la impresora
            }

            if (_formularioPrincipal != null)
            {
                _formularioPrincipal.WindowState = FormWindowState.Normal;
            }

            this.Close();

        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            if (clienteAImprimir != null)
            // Dibujar los detalles del cliente en la página
            e.Graphics.DrawString($"Nombre: {clienteAImprimir.Nombre}", new Font("Arial", 12), Brushes.Black, 100, 100);
            e.Graphics.DrawString($"Apellido: {clienteAImprimir.Apellido}", new Font("Arial", 12), Brushes.Black, 100, 130);
            e.Graphics.DrawString($"DNI: {clienteAImprimir.DNI}", new Font("Arial", 12), Brushes.Black, 100, 160);
            e.Graphics.DrawString($"Domicilio: {clienteAImprimir.Direccion}", new Font("Arial", 12), Brushes.Black, 100, 190);
            e.Graphics.DrawString($"Teléfono: {clienteAImprimir.Telefono}", new Font("Arial", 12), Brushes.Black, 100, 220);
            e.Graphics.DrawString($"Mail: {clienteAImprimir.Email}", new Font("Arial", 12), Brushes.Black, 100, 250);
            e.Graphics.DrawString($"Es Socio: {(clienteAImprimir.EsSocio ? "Sí" : "No")}", new Font("Arial", 12), Brushes.Black, 100, 280);

            // Aquí puedes añadir más información o gráficos si es necesario
        }


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmación de cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                Enviar_Registro_Click(sender, e);  // Ejecutar el mismo método que al hacer click en el botón
                e.Handled = true;        // Evita que el evento continúe propagándose
            }
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {// Mostrar el formulario de Menu nuevamente
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
                // Cargar la imagen en el PictureBox si el archivo existe
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
    }
}