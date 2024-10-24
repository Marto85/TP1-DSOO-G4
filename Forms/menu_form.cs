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

namespace DSOO_Grupo4_TP1
{
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
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

        private void menu_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Salir_Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        }

        private void Cobrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Pago_Form();
            formulario.ShowDialog();
        }

        public List<Cliente> CargarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM cliente";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Verificamos si las columnas son NULL antes de asignar los valores
                                DateTime fechaIngreso = reader.IsDBNull(reader.GetOrdinal("FechaIngreso")) ? DateTime.MinValue : reader.GetDateTime("FechaIngreso");
                                string nombre = reader.IsDBNull(reader.GetOrdinal("Nombre")) ? string.Empty : reader.GetString("Nombre");
                                string apellido = reader.IsDBNull(reader.GetOrdinal("Apellido")) ? string.Empty : reader.GetString("Apellido");
                                int dni = reader.IsDBNull(reader.GetOrdinal("DNI")) ? 0 : reader.GetInt32("DNI");
                                string direccion = reader.IsDBNull(reader.GetOrdinal("Direccion")) ? string.Empty : reader.GetString("Direccion");
                                string telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? string.Empty : reader.GetString("Telefono");
                                string email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString("Email");
                                string imagenPerfil = reader.IsDBNull(reader.GetOrdinal("Imagen_Perfil")) ? string.Empty : reader.GetString("Imagen_Perfil");
                                bool esSocio = !reader.IsDBNull(reader.GetOrdinal("EsSocio")) && reader.GetBoolean("EsSocio");
                                bool esApto = !reader.IsDBNull(reader.GetOrdinal("EsApto")) && reader.GetBoolean("EsApto");

                                decimal abonoMensual = reader.IsDBNull(reader.GetOrdinal("AbonoMensualSocios")) ? 10000 : reader.GetDecimal("AbonoMensualSocios");
                                MessageBox.Show($"Cargando cliente: {nombre} con abono {reader["AbonoMensualSocios"]}");
                                Cliente cliente = new Cliente(
                                    fechaIngreso,
                                    nombre,
                                    apellido,
                                    dni,
                                    direccion,
                                    telefono,
                                    email,
                                    imagenPerfil,
                                    abonoMensual,
                                    esSocio,
                                    esApto
                                );

                                if (esSocio)
                                {
                                    cliente.SetAbonoMensualSocios(reader.IsDBNull(reader.GetOrdinal("AbonoMensualSocios")) ? 10000 : reader.GetDecimal("AbonoMensualSocios"));
                                }

                                listaClientes.Add(cliente);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return listaClientes;
        }


        private void Btn_Modifica_Abono_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo valor del abono mensual para socios:", "Modificar Abono Mensual", "10000");

            if (decimal.TryParse(input, out decimal nuevoAbono))
            {
                ActualizarAbonoSociosEnBaseDeDatos(nuevoAbono);

                List<Cliente> listaDeClientes = CargarClientes();
                foreach (Cliente cliente in listaDeClientes)
                {
                    if (cliente.EsSocio)
                    {
                        cliente.SetAbonoMensualSocios(nuevoAbono);
                    }
                }

                MessageBox.Show("El abono mensual se ha actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El valor ingresado no es válido. Intente nuevamente.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
