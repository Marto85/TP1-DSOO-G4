using DSOO_Grupo4_TP1.Datos;
using DSOO_Grupo4_TP1.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_Grupo4_TP1.Forms
{
    public partial class Pago_Form : Form
    {
        private Cliente clienteActual;
        private Conexion conexion;
        public Pago_Form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Pago_Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            Form menuForm = Application.OpenForms["Menu_Form"];
            if (menuForm != null)
            {
                menuForm.Show();
            }

            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void Buscar_Cliente_Click(object sender, EventArgs e)
        {
            conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString;
            int dni_usuario = int.Parse(DNI_Pagos.Text);
            total_pago.Text = "0.00";

            if (dni_usuario > 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT Nombre, Apellido, DNI, Direccion, Telefono, Email, EsSocio, Imagen_Perfil, AbonoMensualSocios FROM cliente WHERE DNI = @dni_usuario";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@dni_usuario", dni_usuario);

                            // Ejecuta la consulta y obtiene el resultado
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Verificar si los campos son NULL antes de obtener su valor
                                    string nombre = reader.IsDBNull(reader.GetOrdinal("Nombre")) ? string.Empty : reader.GetString("Nombre");
                                    string apellido = reader.IsDBNull(reader.GetOrdinal("Apellido")) ? string.Empty : reader.GetString("Apellido");
                                    int dni = reader.IsDBNull(reader.GetOrdinal("DNI")) ? 0 : reader.GetInt32("DNI");
                                    string direccion = reader.IsDBNull(reader.GetOrdinal("Direccion")) ? string.Empty : reader.GetString("Direccion");
                                    string telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? string.Empty : reader.GetString("Telefono");
                                    string email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString("Email");
                                    string imagenPerfil = reader.IsDBNull(reader.GetOrdinal("Imagen_Perfil")) ? string.Empty : reader.GetString("Imagen_Perfil");
                                    bool esSocio = !reader.IsDBNull(reader.GetOrdinal("EsSocio")) && reader.GetBoolean("EsSocio");
                                    decimal abonoMensualSocios = reader.IsDBNull(reader.GetOrdinal("AbonoMensualSocios")) ? 0 : reader.GetDecimal("AbonoMensualSocios");


                                    clienteActual = new Cliente(DateTime.Now, nombre, apellido, dni, direccion, telefono, email, imagenPerfil, esSocio: esSocio);
                                    if (esSocio)
                                    {
                                        label_AbonoMensual.Visible = true;
                                        txt_AbonoMensual.Visible = true;
                                        label_Pagar_Actividades.Visible = false;
                                        lista_actividades.Visible = false;
                                        if (Frecuencia_Pago.Items.Contains("Semanal"))
                                        {
                                            Frecuencia_Pago.Items.Remove("Semanal");
                                        }

                                        if (Frecuencia_Pago.Items.Contains("Quincenal"))
                                        {
                                            Frecuencia_Pago.Items.Remove("Quincenal");
                                        }
                                    }
                                    else
                                    {
                                        label_AbonoMensual.Visible = false;
                                        txt_AbonoMensual.Visible = false;
                                        label_Pagar_Actividades.Visible = true;
                                        lista_actividades.Visible = true;

                                        // Restauramos las opciones si no es socio
                                        if (!Frecuencia_Pago.Items.Contains("Semanal"))
                                        {
                                            Frecuencia_Pago.Items.Insert(0, "Semanal");
                                        }

                                        if (!Frecuencia_Pago.Items.Contains("Quincenal"))
                                        {
                                            Frecuencia_Pago.Items.Insert(0, "Quincenal");
                                        }
                                    }
                                    Txt_Nombre.Text = nombre;
                                    Txt_Apellido.Text = apellido;
                                    Txt_EsSocio.Text = esSocio ? "SI" : "NO";
                                    txt_AbonoMensual.Text = abonoMensualSocios.ToString();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ningún cliente con el DNI proporcionado.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la conexión: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void CalcularTotalSocios()
        {
            if (Txt_EsSocio.Text == "SI")
            {
                decimal abonoMensual;
                
                if (decimal.TryParse(txt_AbonoMensual.Text, out abonoMensual))
                {
                    // Verificar si se ha seleccionado una opción en el ComboBox de frecuencia de pago
                    if (Frecuencia_Pago.SelectedItem != null)
                    {
                        string frecuenciaPago = Frecuencia_Pago.SelectedItem.ToString();
                        decimal totalPagar = 0;

                        switch (frecuenciaPago)
                        {
                            case "Mensual":
                                totalPagar = abonoMensual;
                                break;
                            case "Trimestral":
                                totalPagar = abonoMensual * 3 * 0.95m; // 5% de descuento
                                break;
                            case "Semestral":
                                totalPagar = abonoMensual * 6 * 0.90m; // 10% de descuento
                                break;
                            case "Anual":
                                totalPagar = abonoMensual * 12 * 0.75m; // 25% de descuento
                                break;
                            default:
                                MessageBox.Show("Por favor selecciona una frecuencia de pago válida.");

                                return;
                        }

                        total_pago.Text = totalPagar.ToString("C"); // Mostrar como moneda
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona una frecuencia de pago.");
                    }
                }
                else
                {
                    MessageBox.Show("El valor del abono mensual no es válido.");
                }
            }
            else
            {
               
                MessageBox.Show("Este cliente no es socio.");
            }
        }

        private decimal ObtenerPrecioActividad(string nombreActividad)
        {
            Conexion conexion = Conexion.getInstancia();
            decimal precioActividad = 0;

            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT PrecioNoSocio FROM Actividad WHERE Nombre = @NombreActividad";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreActividad", nombreActividad);

                        object resultado = cmd.ExecuteScalar();
                        if (resultado != null)
                        {
                            precioActividad = Convert.ToDecimal(resultado);
                        }
                        else
                        {
                            MessageBox.Show("La actividad seleccionada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el precio de la actividad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return precioActividad;
        }

        private void CalcularTotalNoSocios()
        {
            decimal totalPagar = 0;

            if (Frecuencia_Pago.SelectedItem != null)
            {
                string frecuenciaPago = Frecuencia_Pago.SelectedItem.ToString();

                foreach (var item in lista_actividades.CheckedItems)
                {
                    string nombreActividad = item.ToString();
                    decimal precioActividad = ObtenerPrecioActividad(nombreActividad);
                    decimal precioConFrecuencia = 0;

                    switch (frecuenciaPago)
                    {
                        case "Semanal":
                            precioConFrecuencia = (precioActividad / 4) * 1.10m; // Recargo del 10%
                            break;
                        case "Quincenal":
                            precioConFrecuencia = (precioActividad / 2) * 1.05m; // Recargo del 5%
                            break;
                        case "Mensual":
                            precioConFrecuencia = precioActividad; // Precio mensual sin recargo/bonificación
                            break;
                        case "Trimestral":
                            precioConFrecuencia = (precioActividad * 3) * 0.95m; // Descuento del 5%
                            break;
                        case "Semestral":
                            precioConFrecuencia = (precioActividad * 6) * 0.90m; // Descuento del 10%
                            break;
                        case "Anual":
                            precioConFrecuencia = (precioActividad * 12) * 0.75m; // Descuento del 25%
                            break;
                        default:
                            MessageBox.Show("Por favor selecciona una frecuencia de pago válida.");
                            return;
                    }

                    totalPagar += precioConFrecuencia;
                }

                total_pago.Text = totalPagar.ToString("C");
            }
            else
            {
                MessageBox.Show("Por favor selecciona una frecuencia de pago.");
            }
        }

        private void Btn_Calcular_Total_Click(object sender, EventArgs e)
        {
            total_pago.Text = "0.00";
            if (Txt_EsSocio.Text == "SI")
            {
                CalcularTotalSocios();
            }
            else if (Txt_EsSocio.Text == "NO")
            {
                CalcularTotalNoSocios();
            }
            else 
            {
                MessageBox.Show("No se ha seleccionado un tipo de cliente adecuadamente.");
            }
        }
    }
}
