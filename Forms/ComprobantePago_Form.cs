using DSOO_Grupo4_TP1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            this.AcceptButton = Btn_ImprimirComprobante;
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
            _datosComprobante.TryGetValue("NumeroComprobante", out var numeroComprobante);
            txt_NroComp.Text = numeroComprobante?.ToString();

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
            Btn_ImprimirComprobante.BackColor = SystemColors.Highlight;
        }

        private void ImprimirComprobante_MouseLeave(object sender, EventArgs e)
        {
            Btn_ImprimirComprobante.BackColor = SystemColors.Control;
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

        private void Btn_ImprimirComprobante_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas imprimir el comprobante?", "'Yes' para imprimirlo - 'No' para guardarlo como jpg",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (resultado == DialogResult.Yes)
            {
                ImprimirComprobante();
            }
            else if (resultado == DialogResult.No)
            {
                GuardarComoJPG();
            }
            else if (resultado == DialogResult.Cancel)
            {

            }
        }

        private void ImprimirComprobante()
        {
            PrintDocument impresora = new PrintDocument();

            // Ajustar a un tamaño personalizado más ancho y largo
            impresora.DefaultPageSettings.PaperSize = new PaperSize("Comprobante Ampliado", 1600, 1350);

            impresora.PrintPage += (sender, e) =>
            {
                using (Bitmap bitmap = new Bitmap(1600, 1350))
                {
                    this.DrawToBitmap(bitmap, new Rectangle(0, 0, 1600, 1350));
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
                saveFileDialog.Title = "Guardar Comprobante como JPG";
                saveFileDialog.FileName = "Comprobante";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bitmap = new Bitmap(1600, 1350)) // Mayor ancho y altura para mejor encuadre
                    {
                        this.DrawToBitmap(bitmap, new Rectangle(0, 0, 1600, 1350));

                        bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                        MessageBox.Show($"Comprobante guardado en: {saveFileDialog.FileName}", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }



    }

}
