using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class Foto_form : Form
    {
        private FilterInfoCollection videoDevices; // Colección de dispositivos de video
        private VideoCaptureDevice videoSource;    // Dispositivo de captura de video (cámara)
        string folderPath = Path.Combine(Application.StartupPath, @"..\..\Resources\Captures");
        private Form _formularioAltaCliente;
        public Foto_form(AltaCliente_Form formularioAltaCliente)
        {
            InitializeComponent();
            CargarDispositivosDeVideo();
            _formularioAltaCliente = formularioAltaCliente;
        }

        private void CargarDispositivosDeVideo()
        {
            // Buscar todos los dispositivos de video disponibles (cámaras)
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No se encontraron cámaras disponibles.");
                return;
            }

            // Cargar el primer dispositivo (cámara) disponible
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
            videoSource.Start();
        }

        // Este método maneja el evento NewFrame, donde se obtienen los fotogramas de video
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            Video_box.Image = frame; // Mostrar el fotograma actual en un PictureBox
        }

        // Botón para tomar la foto
        private void BtnCapturarFoto_Click(object sender, EventArgs e)
        {
            if (Video_box.Image != null)
            {
                try
                {
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath); // Crear la carpeta si no existe
                    }

                    // Generar un nombre único para la imagen usando la fecha/hora actual
                    string fileName = $"cliente_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.jpg";
                    string filePath = Path.Combine(folderPath, fileName);

                    // Guardar la imagen
                    Video_box.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show($"Foto guardada exitosamente");

                    //_formularioAltaCliente.ImagenPerfil                
                    if (_formularioAltaCliente != null)
                    {
                        // Llamar al método público AsignarImagenPerfil
                        (_formularioAltaCliente as AltaCliente_Form)?.AsignarImagenPerfil(filePath);
                    }
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la imagen: {ex.Message}");
                }
            }
        }

        // Al cerrar el formulario, detener la captura de video
        private void CameraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }
    }
}
