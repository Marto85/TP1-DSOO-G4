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

        public ComprobantePago_Form(Dictionary<string, object> datosComprobante)
        {
            InitializeComponent();
            _datosComprobante = datosComprobante;

            MostrarDatosComprobante();
        }

        private void MostrarDatosComprobante()
        {
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

    }

}
