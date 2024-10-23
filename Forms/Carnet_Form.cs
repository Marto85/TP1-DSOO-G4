using AForge.Video;
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

namespace DSOO_Grupo4_TP1.Forms
{
    public partial class Carnet_Form : Form
    {
        public Carnet_Form()
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
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmación de cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Método para asignar los datos del cliente a los controles del formulario
        public void SetDatosCliente(string nombre, string apellido, int dni, string imagenPerfil, bool esSocio)
        {
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblDNI.Text = dni.ToString();

            // Cargar la imagen del perfil si existe
            if (!string.IsNullOrEmpty(imagenPerfil) && File.Exists(imagenPerfil))
            {
                pictureBoxPerfil.Image = Image.FromFile(imagenPerfil);
            }
            else
            {
                // Asignar una imagen por defecto si no tiene perfil
                pictureBoxPerfil.Image = Properties.Resources.sports_club_logo;
            }

            // Si es socio, puedes mostrar un mensaje o un indicador
            lblSocio.Text = esSocio ? "Socio" : "No Socio";
        }

        private void Btn_Imprimir_Carnet_Click(object sender, EventArgs e)
        {
            // Cuadro de diálogo para elegir la acción
            DialogResult resultado = MessageBox.Show("¿Quieres imprimir el carnet o guardarlo como JPG?", "Selecciona una opción",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0);

            if (resultado == DialogResult.Yes)
            {
                ImprimirCarnet(); // Método para imprimir el carnet
            }
            else if (resultado == DialogResult.No)
            {
                GuardarComoJPG(); // Método para guardar el carnet como JPG
            }
            // Si es Cancel, no se hace nada
        }

        private void ImprimirCarnet()
        {
            // Crear un nuevo objeto PrintDocument
            PrintDocument impresora = new PrintDocument();

            // Establecer el tamaño del papel para el carnet (85mm x 54mm), aproximadamente 340x216 píxeles a 96 DPI
            impresora.DefaultPageSettings.PaperSize = new PaperSize("Carnet", 340, 216);

            // Suscribir el evento PrintPage
            impresora.PrintPage += (sender, e) =>
            {
                using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
                    e.Graphics.DrawImage(bitmap, 0, 0);
                }
            };

            // Crear un cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog
            {
                Document = impresora
            };

            // Abrir el cuadro de diálogo de impresión
            DialogResult result = printDialog.ShowDialog();

            // Si el usuario hace clic en "Imprimir", realizar la impresión
            if (result == DialogResult.OK)
            {
                impresora.Print();
            }
        }

        private void GuardarComoJPG()
        {
            // Crear un cuadro de diálogo de guardado
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Configurar el cuadro de diálogo
                saveFileDialog.Filter = "Archivo JPEG (*.jpg)|*.jpg";
                saveFileDialog.Title = "Guardar Carnet como JPG";
                saveFileDialog.FileName = "Carnet";  // Nombre predeterminado

                // Si el usuario selecciona una ubicación y hace clic en "Guardar"
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crear un Bitmap del formulario, ajustando el tamaño del carnet (85mm x 54mm)
                    using (Bitmap bitmap = new Bitmap(905, 535)) // Ancho y alto del carnet en píxeles
                    {
                        // Dibujar el formulario en el bitmap
                        this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

                        // Guardar la imagen como JPG en la ruta seleccionada
                        bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                        MessageBox.Show($"Carnet guardado en: {saveFileDialog.FileName}", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }



    }
}
