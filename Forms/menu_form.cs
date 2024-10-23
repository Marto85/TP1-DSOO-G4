using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DSOO_Grupo4_TP1.Forms;

namespace DSOO_Grupo4_TP1
{
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AltaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new AltaCliente_Form(this);
            formulario.ShowDialog();
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

        private void menu_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Salir_Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConvertirEnSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Convert_form(this);
            formulario.ShowDialog();

        }

        private void Inscribir_Actividad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Inscribir_Actividad_Form(this);
            formulario.ShowDialog();
        }

        private void Morosos_Menu_Button_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de login nuevamente
            Form loginForm = Application.OpenForms["Login_Form"];
            if (loginForm != null)
            {
                loginForm.Show();
            }

            this.Close();
        }
    }
}
