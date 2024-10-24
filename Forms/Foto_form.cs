using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class Foto_form : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        string rutaImagenes = Path.Combine(Application.StartupPath, @"..\..\Resources\Captures");
        private Form _formularioAltaCliente;
        public Foto_form(AltaCliente_Form formularioAltaCliente)
        {
            InitializeComponent();
            CargarDispositivosDeVideo();
            _formularioAltaCliente = formularioAltaCliente;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CargarDispositivosDeVideo()
        {
            // Buscar todas las camaras disponibles
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No se encontraron cámaras disponibles.");
                return;
            }

            // Cargar la primer camara disponible
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(Video_Frame);
            videoSource.Start();
        }

        private void Video_Frame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            Video_box.Image = frame; // Mostrar el fotograma actual en un PictureBox
        }

        private void BtnCapturarFoto_Click(object sender, EventArgs e)
        {
            if (Video_box.Image != null)
            {
                try
                {
                    if (!Directory.Exists(rutaImagenes))
                    {
                        Directory.CreateDirectory(rutaImagenes);
                    }

                    string nombreImagen = $"cliente_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.jpg";
                    string imagenPath = Path.Combine(rutaImagenes, nombreImagen);

                    Video_box.Image.Save(imagenPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show($"Foto guardada exitosamente");

                    if (_formularioAltaCliente != null)
                    {
                        (_formularioAltaCliente as AltaCliente_Form)?.AsignarImagenPerfil(imagenPath);
                    }
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la imagen: {ex.Message}");
                }
            }
        }

        private void CameraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
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

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmación de cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource = null;
                }
                Application.Exit();
            }
        }

        private void Foto_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
