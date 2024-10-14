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
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
        }

        private void AltaSocio_Click(object sender, EventArgs e)
        {
            Form formulario = new AltaCliente_Form();
            formulario.ShowDialog();
        }

        private void AltaCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new AltaCliente_Form();
            formulario.ShowDialog();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
