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

        public ComprobantePago_Form(Dictionary<string, object> datosComprobante)
        {
            InitializeComponent();
            _datosComprobante = datosComprobante;

            MostrarDatosComprobante();
        }

        private void MostrarDatosComprobante()
        {
            if (_datosComprobante.TryGetValue("Monto", out var monto))
            {
                lblMonto.Text = $"Monto Total: ${monto}";
            }

            if (_datosComprobante.TryGetValue("FechaPago", out var fechaPago))
            {
                lblFechaPago.Text = $"Fecha de Pago: {((DateTime)fechaPago):dd/MM/yyyy}";
            }

            if (_datosComprobante.TryGetValue("ProximoVencimiento", out var proximoVencimiento))
            {
                lblProximoVencimiento.Text = $"Próximo Vencimiento: {((DateTime)proximoVencimiento):dd/MM/yyyy}";
            }

            if (_datosComprobante.TryGetValue("TipoDePago", out var tipoDePago))
            {
                lblTipoPago.Text = $"Tipo de Pago: {tipoDePago}";
            }

            if (_datosComprobante.TryGetValue("Actividades", out var actividades))
            {
                List<Dictionary<string, object>> actividadesList = (List<Dictionary<string, object>>)actividades;
                foreach (var actividad in actividadesList)
                {
                    if (actividad.TryGetValue("ActividadId", out var actividadId) &&
                        actividad.TryGetValue("Precio", out var precio))
                    {
                        lstActividades.Items.Add($"ID: {actividadId} - Precio con Descuento: ${precio}");
                    }
                }
            }
            else
            {
                lstActividades.Visible = false;
            }
        }
    }

}
