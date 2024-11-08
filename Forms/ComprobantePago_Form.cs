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
    public partial class ComprobantePago_Form : Form
    {
        private Dictionary<string, object> _datosComprobante;
        private Cliente _clienteActual;
        private DateTime _proximoVencimiento;
        private string _tipoDePagoSeleccionado;
        private string _formaPago;

        public ComprobantePago_Form(Dictionary<string, object> datosComprobante, Cliente clienteActual, DateTime proximoVencimiento, string tipoDePagoSeleccionado, string formaPago)
        {
            InitializeComponent();
            _datosComprobante = datosComprobante;
            _clienteActual = clienteActual;
            _proximoVencimiento = proximoVencimiento;
            _tipoDePagoSeleccionado = tipoDePagoSeleccionado;
            _formaPago = formaPago;

            MostrarDatosComprobante();
        }


        private void MostrarDatosComprobante()
        {
            txt_nombreCliente.Text = _clienteActual.Nombre + " " + _clienteActual.Apellido;
            txt_dni.Text = _clienteActual.DNI.ToString();
            txt_frecuenciaPago.Text = _tipoDePagoSeleccionado;
            txt_proximoVencimiento.Text = _proximoVencimiento.ToString("dd/MM/yyyy");
            txt_fechaComprobante.Text = DateTime.Now.ToString("dd/MM/yyyy");
            _datosComprobante.TryGetValue("FormaDePago", out var formaPago);
            txt_formaPago.Text = formaPago?.ToString();

            if (_datosComprobante.TryGetValue("Actividades", out var actividades))
            {
                List<Dictionary<string, object>> actividadesList = (List<Dictionary<string, object>>)actividades;

                foreach (var actividad in actividadesList)
                {
                    int actividadId = Convert.ToInt32(actividad["ActividadId"]);
                    string nombreActividad = actividad["Nombre"].ToString();
                    decimal precio = Convert.ToDecimal(actividad["Precio"]);

                    int rowIndex = dgvActividades.Rows.Add();
                    dgvActividades.Rows[rowIndex].Cells["Codigo"].Value = actividadId;
                    dgvActividades.Rows[rowIndex].Cells["Clase"].Value = nombreActividad;
                    dgvActividades.Rows[rowIndex].Cells["PrecioUnitario"].Value = precio;
                    dgvActividades.Rows[rowIndex].Cells["Bonificacion"].Value = 0; // REVISAR ESTO
                    dgvActividades.Rows[rowIndex].Cells["Subtotal"].Value = precio; // REVISAR ESTO DPS DE VER BONIFICACION
                }
            }
            else
            {
                int rowIndex = dgvActividades.Rows.Add();
                dgvActividades.Rows[rowIndex].Cells["Codigo"].Value = "--";
                dgvActividades.Rows[rowIndex].Cells["Clase"].Value = "Abono Mensual";
                dgvActividades.Rows[rowIndex].Cells["PrecioUnitario"].Value = _datosComprobante["Monto"];
                dgvActividades.Rows[rowIndex].Cells["Bonificacion"].Value = 0; // REVISAR ESTO
                dgvActividades.Rows[rowIndex].Cells["Subtotal"].Value = _datosComprobante["Monto"]; // REVISAR ESTO DPS DE VER BONIFICACION
            }

        }

        private void ImprimirComprobante_MouseEnter(object sender, EventArgs e)
        {
            ImprimirComprobante.BackColor = SystemColors.Highlight;
        }

        private void ImprimirComprobante_MouseLeave(object sender, EventArgs e)
        {
            ImprimirComprobante.BackColor = SystemColors.Control;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_formaPago_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
