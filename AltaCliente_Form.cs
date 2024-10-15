using DSOO_Grupo4_TP1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_Grupo4_TP1
{
    public partial class AltaCliente_Form : Form
    {
        public AltaCliente_Form()
        {
            InitializeComponent();
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

            Cliente nuevoCliente = new Cliente(fechaIngreso, nombre, apellido, dni, domicilio, telefono, mail, esSocio);
            nuevoCliente.AltaCliente();
            this.Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Nombre_Registro_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Nombre_Registro_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void Nombre_Registro_Enter(object sender, EventArgs e)
        {
            if (Nombre_Registro.Text == "Nombre")
            {
                Nombre_Registro.Text = "";
                Nombre_Registro.UseSystemPasswordChar = true;
                Nombre_Registro.ForeColor = Color.Black;
            }
        }

        private void Nombre_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nombre_Registro.Text))
            {
                Nombre_Registro.UseSystemPasswordChar = false;
                Nombre_Registro.Text = "Nombre";
                Nombre_Registro.ForeColor = Color.DarkGray;
            }
        }
    }
}
