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

namespace DSOO_Grupo4_TP1.Forms
{
    public partial class ClientesMorosos_Form : Form
    {
        public ClientesMorosos_Form()
        {
            InitializeComponent();
        }

        public ClientesMorosos_Form(List<dynamic> clientesVencidos)
        {
            InitializeComponent();

            dgvClientesVencidos.DataSource = clientesVencidos;

            dgvClientesVencidos.Columns["Id"].HeaderText = "ID";
            dgvClientesVencidos.Columns["Nombre"].HeaderText = "Nombre";
            dgvClientesVencidos.Columns["Apellido"].HeaderText = "Apellido";
            dgvClientesVencidos.Columns["DNI"].HeaderText = "DNI";
            dgvClientesVencidos.Columns["EsSocio"].HeaderText = "Es Socio";
            dgvClientesVencidos.Columns["FechaUltimoPago"].HeaderText = "Fecha Último Pago";
            dgvClientesVencidos.Columns["ActividadesVencidas"].HeaderText = "Actividades Vencidas";
            dgvClientesVencidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
