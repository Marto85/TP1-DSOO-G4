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
using DSOO_Grupo4_TP1.Forms;
using DSOO_Grupo4_TP1.Models;
using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using Microsoft.Win32.SafeHandles;

namespace DSOO_Grupo4_TP1
{
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private ClubDeportivo _clubDeportivo;

        public Menu_form(ClubDeportivo clubDeportivo)
        {
            InitializeComponent();
            _clubDeportivo = clubDeportivo;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AltaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new AltaCliente_Form(this);
            formulario.ShowDialog();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void Menu_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Salir_Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConvertirEnSocio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Convert_form(this);
            formulario.ShowDialog();

        }

        private void Inscribir_Actividad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Inscribir_Actividad_Form(this);
            formulario.ShowDialog();
        }

        private void Morosos_Menu_Button_Click(object sender, EventArgs e)
        {
            List<dynamic> clientesVencidos = _clubDeportivo.ObtenerClientesConPagoVencido();

            if (clientesVencidos.Count == 0)
            {
                MessageBox.Show("No hay clientes con pagos vencidos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Crear y mostrar el formulario ClientesMorosos_Form con la lista de clientes vencidos
                ClientesMorosos_Form formulario = new ClientesMorosos_Form(clientesVencidos);
                this.Hide();
                formulario.ShowDialog();
                this.Show();
            }
        }

        private void Cobrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Pago_Form();
            formulario.ShowDialog();
        }

        private void Btn_Modifica_Abono_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo valor del abono mensual para socios:", "Modificar Abono Mensual", "10000");

            if (!string.IsNullOrEmpty(input)) { 
                if (decimal.TryParse(input, out decimal nuevoAbono))
                {
                    ActualizarAbonoSociosEnBaseDeDatos(nuevoAbono);
                    MessageBox.Show("El abono mensual se ha actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es válido. Intente nuevamente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActualizarAbonoSociosEnBaseDeDatos(decimal nuevoAbono)
        {
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();

                    string updateQuery = @"UPDATE cliente SET AbonoMensualSocios = @nuevoAbono WHERE EsSocio = true";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nuevoAbono", nuevoAbono);
                        cmd.ExecuteNonQuery();
                    }

                    // Actualizamos el valor por defecto en funcion del nuevo abono definido
                    string alterTableQuery = @"ALTER TABLE cliente ALTER COLUMN AbonoMensualSocios SET DEFAULT @nuevoAbono";
                    using (MySqlCommand cmd = new MySqlCommand(alterTableQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nuevoAbono", nuevoAbono);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al actualizar el abono: {ex.Message}", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
    }
}
