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

namespace DSOO_Grupo4_TP1
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username_login.Text == "Nombre de usuario")
            {
                username_login.Text = "";
                username_login.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_login.Text))
            {
                username_login.Text = "Nombre de usuario";
                username_login.ForeColor = Color.DarkGray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password_login.Text == "Contraseña")
            {
                password_login.Text = "";
                password_login.UseSystemPasswordChar = true;
                password_login.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(password_login.Text))
            {
                password_login.UseSystemPasswordChar = false;
                password_login.Text = "Contraseña";
                password_login.ForeColor = Color.DarkGray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void username_login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void password_login_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
