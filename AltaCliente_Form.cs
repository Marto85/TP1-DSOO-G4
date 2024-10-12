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

        private void Enviar_Registro_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime fechaIngreso =  DateTime.Now;
            string nombre = Nombre_Registro.Text;
            string apellido = Apellido_Registro.Text;
            int dni =  int.Parse(DNI_Registro.Text);
            string domicilio = Domicilio_Registro.Text;
            string mail = Mail_Registro.Text;
            string telefono = Telefono_Registro.Text;
            string tipoCliente = Tipo_Cliente_Registro.SelectedItem.ToString();
            
            if (tipoCliente == "Cliente por actividades")
            {
                Cliente nuevoCliente =  new Cliente(fechaIngreso, nombre, apellido, dni, domicilio, telefono, mail);
            }
            else if (tipoCliente == "Es Socio")
            {
                Socio nuevoSocio = new Socio(nombre, apellido, activo, esApto, this);
            }
        }
    }
}
