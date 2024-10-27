using DSOO_Grupo4_TP1.Datos;
using DSOO_Grupo4_TP1.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSOO_Grupo4_TP1.Forms
{
    public partial class Pago_Form : Form
    {
        private Cliente clienteActual;
        private Conexion conexion;
        List<string> actividades_seleccionadas = new List<string>();
        private List<Actividad> actividadesDisponibles;

        private Boolean pagoSocio; // variable bandera para para controlar que tipo de pago procesar en el ultimo metodo de clase
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
                                    Txt_DNI.Text = dni.ToString();
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

        public void CargarActividades()
        {
            actividadesDisponibles = ObtenerActividadesDesdeDB();
        }

        private void CalcularMontoTotalSocios()
        {
            if (Txt_EsSocio.Text != "SI")
            {
                MessageBox.Show("Este cliente no es socio.");
                return;
            }

            decimal abonoMensual;
            if (!decimal.TryParse(txt_AbonoMensual.Text, out abonoMensual))
            {
                MessageBox.Show("El valor del abono mensual no es válido.");
                return;
            }

            // Verificar si se ha seleccionado una opción en el ComboBox de frecuencia de pago
            if (Frecuencia_Pago.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona una frecuencia de pago.");
                return;
            }

            string frecuenciaPago = Frecuencia_Pago.SelectedItem.ToString();
            decimal totalPagar = abonoMensual; // Base mensual

            switch (frecuenciaPago)
            {
                case "Mensual":
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

            // Mostrar el total calculado como moneda
            total_pago.Text = totalPagar.ToString("C");
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
                CalcularMontoTotalSocios();
                pagoSocio = true;
            }
            else if (Txt_EsSocio.Text == "NO")
            {
                CalcularTotalNoSocios();
                pagoSocio = false;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un tipo de cliente adecuadamente.");
            }
        }

        // Método para obtener las actividades desde la base de datos
        public List<Actividad> ObtenerActividadesDesdeDB()
        {
            List<Actividad> actividades = new List<Actividad>();

            Conexion conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Id, Nombre, Descripcion, PrecioNoSocio, Horario, CuposDisponibles, Profesor FROM Actividad";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Actividad actividad = new Actividad
                            {
                                Id = reader.GetInt32("Id"),
                                Nombre = reader.GetString("Nombre"),
                                Descripcion = reader.GetString("Descripcion"),
                                Precio = reader.GetDecimal("PrecioNoSocio"),
                                Horario = reader.GetString("Horario"),
                                CuposDisponibles = reader.GetInt32("CuposDisponibles"),
                                Profesor = reader.GetString("Profesor")
                            };

                            actividades.Add(actividad);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return actividadesDisponibles = actividades;
        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            // Llama a ObtenerActividadesDesdeDB para cargar la lista
            List<Actividad> actividadesDisponibles = ObtenerActividadesDesdeDB();

            if (actividadesDisponibles == null || actividadesDisponibles.Count == 0)
            {
                MessageBox.Show("No se encontraron actividades disponibles.");
                return;
            }
            Conexion conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString;

            // Obtener datos del formulario
            int clienteDni = Txt_DNI.Text == "" ? 0 : int.Parse(Txt_DNI.Text);
            string monto = total_pago.Text;
            decimal montoDecimal = decimal.Parse(monto.Replace("$", ""));
            DateTime fechaPago = DateTime.Now;
            string tipoDePagoSeleccionado = Frecuencia_Pago.SelectedItem?.ToString();
            DateTime proximoVencimiento = CalcularProximoVencimiento(fechaPago, tipoDePagoSeleccionado);

            int tipoDePagoId = tipoDePagoSeleccionado switch
            {
                "Semanal" => 1,
                "Quincenal" => 2,
                "Mensual" => 3,
                "Trimestral" => 4,
                "Semestral" => 5,
                "Anual" => 6,
                _ => 0
            };

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consulta para obtener el Id del cliente a partir del DNI
                    string querySelectClienteId = "SELECT Id FROM Cliente WHERE DNI = @DNI";
                    int clienteId = 0;

                    using (MySqlCommand cmdSelect = new MySqlCommand(querySelectClienteId, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@DNI", clienteDni);
                        object result = cmdSelect.ExecuteScalar();

                        if (result != null)
                        {
                            clienteId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.");
                            return;
                        }
                    }

                    if (pagoSocio == true)
                    {
                        // Inserción del pago en la base de datos
                        string queryInsert = "INSERT INTO Pago (Cliente_Id, Monto, FechaPago, ProximoVencimiento, Id_tipo_de_pago) " +
                                             "VALUES (@Cliente_Id, @Monto, @FechaPago, @ProximoVencimiento, @Id_tipo_de_pago)";
                        using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@Cliente_Id", clienteId);
                            cmdInsert.Parameters.AddWithValue("@Monto", montoDecimal);
                            cmdInsert.Parameters.AddWithValue("@FechaPago", fechaPago);
                            cmdInsert.Parameters.AddWithValue("@ProximoVencimiento", proximoVencimiento);
                            cmdInsert.Parameters.AddWithValue("@Id_tipo_de_pago", tipoDePagoId);

                            cmdInsert.ExecuteNonQuery();
                            MessageBox.Show("Pago procesado correctamente.");
                        }
                    }

                    else if (pagoSocio == false)
                    {
                        List<int> actividadesSeleccionadasIds = new List<int>();

                        foreach (var actividadNombre in lista_actividades.CheckedItems)
                        {
                            // Supongamos que tienes una lista o diccionario de actividades por nombre
                            Actividad actividadSeleccionada = actividadesDisponibles.FirstOrDefault(a => a.Nombre == actividadNombre.ToString());

                            if (actividadSeleccionada != null)
                            {
                                actividadesSeleccionadasIds.Add(actividadSeleccionada.Id);
                            }
                            else
                            {
                                MessageBox.Show($"Actividad {actividadNombre} no encontrada en la lista de actividades disponibles.");
                            }
                        }

                        // Recorrer cada actividad seleccionada y procesar el pago para cada una
                        foreach (int actividadId in actividadesSeleccionadasIds)
                        {
                            // Recuperar el precio de la actividad
                            string queryPrecioActividad = "SELECT PrecioNoSocio FROM Actividad WHERE Id = @Id";
                            decimal precioActividad;

                            using (MySqlCommand cmdPrecio = new MySqlCommand(queryPrecioActividad, conn))
                            {
                                cmdPrecio.Parameters.AddWithValue("@Id", actividadId);
                                object result = cmdPrecio.ExecuteScalar();

                                if (result != null)
                                {
                                    precioActividad = Convert.ToDecimal(result);
                                }
                                else
                                {
                                    MessageBox.Show("Actividad no encontrada.");
                                    continue;
                                }
                            }


                            // Insertar el pago en la tabla Pago_Actividad
                            string queryInsertPagoActividad = @"INSERT INTO Pago_Actividad 
                                                    (Cliente_id, Actividad_id, Monto, FechaPago, ProximoVencimiento) 
                                                    VALUES 
                                                    (@ClienteId, @ActividadId, @Monto, @FechaPago, @ProximoVencimiento)";

                            using (MySqlCommand cmdInsertPago = new MySqlCommand(queryInsertPagoActividad, conn))
                            {
                                cmdInsertPago.Parameters.AddWithValue("@ClienteId", clienteId);
                                cmdInsertPago.Parameters.AddWithValue("@ActividadId", actividadId);
                                cmdInsertPago.Parameters.AddWithValue("@Monto", precioActividad);
                                cmdInsertPago.Parameters.AddWithValue("@FechaPago", fechaPago);
                                cmdInsertPago.Parameters.AddWithValue("@ProximoVencimiento", proximoVencimiento);

                                cmdInsertPago.ExecuteNonQuery();
                            }

                            // Actualizar la disponibilidad de cupos para la actividad
                            string queryActualizarCupos = "UPDATE Actividad SET CuposDisponibles = CuposDisponibles - 1 WHERE Id = @Id AND CuposDisponibles > 0";

                            using (MySqlCommand cmdActualizarCupos = new MySqlCommand(queryActualizarCupos, conn))
                            {
                                cmdActualizarCupos.Parameters.AddWithValue("@Id", actividadId);
                                cmdActualizarCupos.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Pago de actividades procesado correctamente.");
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
          
        private DateTime CalcularProximoVencimiento(DateTime fechaPago, string tipoDePago)
        {
            DateTime proximoVencimiento = fechaPago;
            string? frecuenciaPago = Frecuencia_Pago.SelectedItem.ToString();
            switch (frecuenciaPago)
            {
                case "Semanal":
                    proximoVencimiento = fechaPago.AddDays(7);
                    break;
                case "Quincenal":
                    proximoVencimiento = fechaPago.AddDays(15);
                    break;
                case "Mensual":
                    proximoVencimiento = fechaPago.AddMonths(1);
                    break;
                case "Trimestral":
                    proximoVencimiento = fechaPago.AddMonths(3);
                    break;
                case "Semestral":
                    proximoVencimiento = fechaPago.AddMonths(6);
                    break;
                case "Anual":
                    proximoVencimiento = fechaPago.AddYears(1);
                    break;
                default:
                    proximoVencimiento = fechaPago;
                    break;
            }

            return proximoVencimiento;
        }


        

    }
}
