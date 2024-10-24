﻿using AForge.Video;
using DSOO_Grupo4_TP1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        public void SetDatosCliente(string nombre, string apellido, int dni, string imagenPerfil, bool esSocio)
        {
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblDNI.Text = dni.ToString();

            if (!string.IsNullOrEmpty(imagenPerfil) && File.Exists(imagenPerfil))
            {
                pictureBoxPerfil.Image = Image.FromFile(imagenPerfil);
            }
            else
            {
                pictureBoxPerfil.Image = Properties.Resources.sports_club_logo;
            }

            lblSocio.Text = esSocio ? "Socio" : "No Socio";
        }

        private void Btn_Imprimir_Carnet_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas imprimir el carnet?", "'Yes' para imprimirlo - 'No' para guardarlo como jpg",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (resultado == DialogResult.Yes)
            {
                ImprimirCarnet();
            }
            else if (resultado == DialogResult.No)
            {
                GuardarComoJPG();
            }
            else if (resultado == DialogResult.Cancel)
            {

            }
        }

        private void ImprimirCarnet()
        {
            PrintDocument impresora = new PrintDocument();

            impresora.DefaultPageSettings.PaperSize = new PaperSize("Carnet", 905, 535);

            impresora.PrintPage += (sender, e) =>
            {
                using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
                    e.Graphics.DrawImage(bitmap, 0, 0);
                }
            };

            PrintDialog printDialog = new PrintDialog
            {
                Document = impresora
            };

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                impresora.Print();
            }
        }

        private void GuardarComoJPG()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo JPEG (*.jpg)|*.jpg";
                saveFileDialog.Title = "Guardar Carnet como JPG";
                saveFileDialog.FileName = "Carnet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bitmap = new Bitmap(905, 535))
                    {
                        this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

                        bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                        MessageBox.Show($"Carnet guardado en: {saveFileDialog.FileName}", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Carnet_Form_MouseDown(object sender, MouseEventArgs e)
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
