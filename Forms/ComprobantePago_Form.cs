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

                    // Agrega una nueva fila en el DataGridView y asigna los valores
                    int rowIndex = dgvActividades.Rows.Add();
                    dgvActividades.Rows[rowIndex].Cells["Codigo"].Value = actividadId;
                    dgvActividades.Rows[rowIndex].Cells["Clase"].Value = nombreActividad;
                    dgvActividades.Rows[rowIndex].Cells["PrecioUnitario"].Value = precio;
                    dgvActividades.Rows[rowIndex].Cells["Bonificacion"].Value = 0; // Asigna un valor si corresponde
                    dgvActividades.Rows[rowIndex].Cells["Subtotal"].Value = precio; // Ajusta el valor si tienes un cálculo
                }
            }

            // Configura otras etiquetas como lblMonto, lblFechaPago, etc.
            // ...
        }

    }

}
