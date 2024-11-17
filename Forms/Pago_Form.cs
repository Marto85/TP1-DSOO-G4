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
        Dictionary<string, object> datosComprobante = new Dictionary<string, object>();

        private Boolean pagoSocio; // variable bandera para para controlar que tipo de pago procesar en el ultimo metodo de clase
        decimal totalSinDescuento = 0;
        decimal descuento = 0;
        public Pago_Form()
        {
            InitializeComponent();
            this.AcceptButton = Btn_Pagar;
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

        public void Buscar_Cliente_Click(object sender, EventArgs e)
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
                    totalSinDescuento = abonoMensual * 3;
                    break;
                case "Semestral":
                    totalPagar = abonoMensual * 6 * 0.90m; // 10% de descuento
                    totalSinDescuento = abonoMensual * 6;
                    break;
                case "Anual":
                    totalPagar = abonoMensual * 12 * 0.75m; // 25% de descuento
                    totalSinDescuento = abonoMensual * 12;
                    break;
                default:
                    MessageBox.Show("Por favor selecciona una frecuencia de pago válida.");
                    return;
            }
            descuento = totalSinDescuento - totalPagar;
           
            // Mostrar el total calculado como moneda
            total_pago.Text = totalPagar.ToString("F2");
        }

        private void CalcularTotalNoSocios()
        {
            datosComprobante.Clear();
            decimal totalPagar = 0;
            totalSinDescuento = 0;
            descuento = 0;

            if (Frecuencia_Pago.SelectedItem != null)
            {
                string frecuenciaPago = Frecuencia_Pago.SelectedItem.ToString();

                foreach (var item in lista_actividades.CheckedItems)
                {   
                    string nombreActividad = item.ToString();
                    decimal precioActividad = ObtenerPrecioActividad(nombreActividad);
                    decimal precioConFrecuencia = 0;
                    decimal descuentoParcial = 0;
                    decimal parcialSinDescuento = 0;

                    switch (frecuenciaPago)
                    {
                        case "Semanal":
                            precioConFrecuencia = (precioActividad / 4) * 1.10m; // Recargo del 10%
                            descuentoParcial = 0;
                            parcialSinDescuento = precioConFrecuencia;
                            totalSinDescuento += precioConFrecuencia;
                            break;
                        case "Quincenal":
                            precioConFrecuencia = (precioActividad / 2) * 1.05m; // Recargo del 5%
                            descuentoParcial = 0;
                            parcialSinDescuento = precioConFrecuencia;
                            totalSinDescuento += precioConFrecuencia;
                            break;
                        case "Mensual":
                            precioConFrecuencia = precioActividad; // Precio mensual sin recargo/bonificación
                            descuentoParcial = 0;
                            parcialSinDescuento = precioConFrecuencia;
                            totalSinDescuento += precioConFrecuencia;
                            break;
                        case "Trimestral":
                            precioConFrecuencia = (precioActividad * 3) * 0.95m; // Descuento del 5%
                            parcialSinDescuento = precioActividad * 3;
                            totalSinDescuento += parcialSinDescuento;
                            descuentoParcial = precioActividad * 3 - precioConFrecuencia;
                            descuento += descuentoParcial;
                            ;

                            break;
                        case "Semestral":
                            precioConFrecuencia = (precioActividad * 6) * 0.90m; // Descuento del 10%
                            parcialSinDescuento = precioActividad * 6;
                            totalSinDescuento += parcialSinDescuento;
                            descuentoParcial = precioActividad * 6 - precioConFrecuencia;
                            descuento += descuentoParcial;
                            break;
                        case "Anual":
                            precioConFrecuencia = (precioActividad * 12) * 0.75m; // Descuento del 25%
                            parcialSinDescuento = precioActividad * 12;
                            totalSinDescuento += parcialSinDescuento;
                            descuentoParcial = precioActividad * 12 - precioConFrecuencia;
                            descuento += descuentoParcial;
                            break;
                        default:
                            MessageBox.Show("Por favor selecciona una frecuencia de pago válida.");
                            return;
                    }

                    if (!datosComprobante.ContainsKey("Actividades") || datosComprobante["Actividades"] == null)
                    {
                        datosComprobante["Actividades"] = new List<Dictionary<string, object>>();
                    }

                      ((List<Dictionary<string, object>>)datosComprobante["Actividades"]).Add(new Dictionary<string, object>
                        {
                            { "Nombre", nombreActividad },
                            { "totalSinDescuento", parcialSinDescuento },
                            { "total", precioConFrecuencia },
                            { "descuento", descuentoParcial },
                        });

                    totalPagar += precioConFrecuencia;
                }
                total_pago.Text = totalPagar.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor selecciona una frecuencia de pago.");
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
            if (formas_de_pago.CheckedItems.Count == 0) {
                MessageBox.Show("Debe seleccionar una forma de pago");
                return;
            }
            List<Actividad> actividadesDisponibles = ObtenerActividadesDesdeDB();

            if (actividadesDisponibles == null || actividadesDisponibles.Count == 0)
            {
                MessageBox.Show("No se encontraron actividades disponibles.");
                return;
            }

            datosComprobante.Clear();

            Conexion conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString;
            Btn_Calcular_Total_Click(sender, e);

            int clienteDni = Txt_DNI.Text == "" ? 0 : int.Parse(Txt_DNI.Text);
            decimal montoDecimal = decimal.Parse(total_pago.Text);
            string tipoDePagoSeleccionado = Frecuencia_Pago.SelectedItem?.ToString();
            string formaPago = formas_de_pago.SelectedItem?.ToString();

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
                    string queryMaxIdPago = "SELECT MAX(Id) FROM Pago";
                    string queryMaxIdPagoActividad = "SELECT MAX(Id) FROM Pago_Actividad";

                    int maxIdPago = 0;
                    int maxIdPagoActividad = 0;

                    using (MySqlCommand cmdMaxPago = new MySqlCommand(queryMaxIdPago, conn))
                    {
                        object result = cmdMaxPago.ExecuteScalar();
                        maxIdPago = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }

                    using (MySqlCommand cmdMaxPagoActividad = new MySqlCommand(queryMaxIdPagoActividad, conn))
                    {
                        object result = cmdMaxPagoActividad.ExecuteScalar();
                        maxIdPagoActividad = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }

                    // Siguiente número de comprobante
                    int numeroComprobante = Math.Max(maxIdPago, maxIdPagoActividad) + 1;
                    string numeroComprobanteFormateado = numeroComprobante.ToString("D8"); // se da formato 8 de digitos

                    datosComprobante["NumeroComprobante"] = numeroComprobanteFormateado;

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

                    DateTime fechaPago = DateTime.Now;
                    DateTime proximoVencimiento = DateTime.Now;

                    if (pagoSocio)
                    {
                        proximoVencimiento = CalcularProximoVencimiento(fechaPago, clienteId, null);
                        string queryInsert = "INSERT INTO Pago (Cliente_Id, Monto, FechaPago, ProximoVencimiento, Id_tipo_de_pago, formaPago) " +
                                              "VALUES (@Cliente_Id, @Monto, @FechaPago, @ProximoVencimiento, @Id_tipo_de_pago, @formaPago)";
                        using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@Cliente_Id", clienteId);
                            cmdInsert.Parameters.AddWithValue("@Monto", montoDecimal);
                            cmdInsert.Parameters.AddWithValue("@FechaPago", fechaPago);
                            cmdInsert.Parameters.AddWithValue("@ProximoVencimiento", proximoVencimiento);
                            cmdInsert.Parameters.AddWithValue("@Id_tipo_de_pago", tipoDePagoId);
                            cmdInsert.Parameters.AddWithValue("@formaPago", formaPago);

                            cmdInsert.ExecuteNonQuery();
                            MessageBox.Show("Pago procesado correctamente.");
                            int pagoId = (int)cmdInsert.LastInsertedId;
                            datosComprobante["PagoId"] = pagoId;
                        }

                        datosComprobante["ClienteId"] = clienteId;
                        datosComprobante["Monto"] = montoDecimal;
                        datosComprobante["totalSinDescuento"] = totalSinDescuento;
                        datosComprobante["descuento"] = descuento;
                        datosComprobante["FechaPago"] = fechaPago;
                        datosComprobante["ProximoVencimiento"] = proximoVencimiento;
                        datosComprobante["TipoDePago"] = tipoDePagoSeleccionado;
                        datosComprobante["FormaDePago"] = formaPago;
                    }
                    else
                    {
                        List<int> actividadesSeleccionadasIds = new List<int>();
                        proximoVencimiento= proximoVencimiento.AddYears(99);
                        foreach (var actividad in (List<Dictionary<string, object>>)datosComprobante["Actividades"])
                        {
                            Actividad actividadSeleccionada = actividadesDisponibles.FirstOrDefault(a => a.Nombre == actividad["Nombre"].ToString());

                            if (actividadSeleccionada != null)
                            {
                                actividadesSeleccionadasIds.Add(actividadSeleccionada.Id);
                                actividad["ActividadId"] = actividadSeleccionada.Id;

                                string queryInsertPagoActividad = @"INSERT INTO Pago_Actividad 
                         (Cliente_id, Actividad_id, Monto, FechaPago, ProximoVencimiento, formaPago)
                         VALUES (@ClienteId, @ActividadId, @Monto, @FechaPago, @ProximoVencimiento, @formaPago)";

                                int pagoId; // Declara pagoId fuera del bloque using
                                DateTime vencimiento = CalcularProximoVencimiento(fechaPago, clienteId, actividadSeleccionada.Id);

                                using (MySqlCommand cmdInsertPago = new MySqlCommand(queryInsertPagoActividad, conn))
                                {
                                    cmdInsertPago.Parameters.AddWithValue("@ClienteId", clienteId);
                                    cmdInsertPago.Parameters.AddWithValue("@ActividadId", actividadSeleccionada.Id);
                                    cmdInsertPago.Parameters.AddWithValue("@Monto", Convert.ToDecimal(actividad["total"]));
                                    cmdInsertPago.Parameters.AddWithValue("@FechaPago", fechaPago);
                                    cmdInsertPago.Parameters.AddWithValue("@ProximoVencimiento", vencimiento);
                                    cmdInsertPago.Parameters.AddWithValue("@formaPago", formaPago);

                                    cmdInsertPago.ExecuteNonQuery();
                                    pagoId = (int)cmdInsertPago.LastInsertedId; // Asigna el valor a pagoId
                                }

                                string queryActualizarCupos = "UPDATE Actividad SET CuposDisponibles = CuposDisponibles - 1 WHERE Id = @Id AND CuposDisponibles > 0";

                                using (MySqlCommand cmdActualizarCupos = new MySqlCommand(queryActualizarCupos, conn))
                                {
                                    cmdActualizarCupos.Parameters.AddWithValue("@Id", actividadSeleccionada.Id);
                                    cmdActualizarCupos.ExecuteNonQuery();
                                }

                                if (vencimiento < proximoVencimiento)
                                {
                                    proximoVencimiento = vencimiento;
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Actividad {actividad["Nombre"]} no encontrada en la lista de actividades disponibles.");
                            }
                        }

                        datosComprobante["Monto"] = total_pago.Text;
                        datosComprobante["FechaPago"] = fechaPago;
                        datosComprobante["TotalSinDescuento"] = totalSinDescuento;
                        datosComprobante["Descuento"] = this.descuento;
                        datosComprobante["ProximoVencimiento"] = proximoVencimiento;
                        datosComprobante["TipoDePago"] = tipoDePagoSeleccionado;
                        datosComprobante["FormaDePago"] = formaPago;

                        MessageBox.Show("Pago de actividades procesado correctamente.");
                    }

                    ComprobantePago_Form comprobante = new ComprobantePago_Form(datosComprobante, clienteActual, proximoVencimiento, tipoDePagoSeleccionado, formaPago);
                    comprobante.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private decimal CalcularDescuento(string tipoDePagoSeleccionado)
        {
            return tipoDePagoSeleccionado switch
            {
                "Trimestral" => 0.95m,
                "Semestral" => 0.90m,
                "Anual" => 0.80m,
                _ => 1m,
            };
        }


        private DateTime CalcularProximoVencimiento(DateTime fechaPago, int clienteId, int ? actividadId)
        {
            string queryUltimoVencimiento = "";
            if (actividadId.HasValue)
            {
                queryUltimoVencimiento = "SELECT ProximoVencimiento FROM Pago_Actividad WHERE Cliente_Id = @clienteId AND Actividad_id = @actividadId ORDER BY ProximoVencimiento DESC LIMIT 1";

            }
            else { 
                queryUltimoVencimiento = "SELECT ProximoVencimiento FROM pago WHERE Cliente_Id =  @clienteId ORDER BY ProximoVencimiento DESC LIMIT 1";
            }

            DateTime ultimoVencimiento = DateTime.Now;
            Conexion conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(queryUltimoVencimiento, conn))
                    {
                        cmd.Parameters.AddWithValue("@clienteId", clienteId);
                        if (actividadId.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@actividadId", actividadId.Value);
                        }

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            ultimoVencimiento = Convert.ToDateTime(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el último vencimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            DateTime proximoVencimiento = ultimoVencimiento != DateTime.MinValue ? ultimoVencimiento : fechaPago;
            string frecuenciaPago = Frecuencia_Pago.SelectedItem?.ToString();

            switch (frecuenciaPago)
            {
                case "Semanal":
                    proximoVencimiento = ultimoVencimiento.AddDays(7);
                    break;
                case "Quincenal":
                    proximoVencimiento = ultimoVencimiento.AddDays(15);
                    break;
                case "Mensual":
                    proximoVencimiento = ultimoVencimiento.AddMonths(1);
                    break;
                case "Trimestral":
                    proximoVencimiento = ultimoVencimiento.AddMonths(3);
                    break;
                case "Semestral":
                    proximoVencimiento = ultimoVencimiento.AddMonths(6);
                    break;
                case "Anual":
                    proximoVencimiento = ultimoVencimiento.AddYears(1);
                    break;
                default:
                    proximoVencimiento = ultimoVencimiento;
                    break;
            }

            return proximoVencimiento;
        }

        private void formas_de_pago_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            {
                // Verificar si se está marcando un nuevo elemento
                if (e.NewValue == CheckState.Checked)
                {
                    // Desmarcar todos los elementos excepto el que se está seleccionando
                    for (int i = 0; i < formas_de_pago.Items.Count; i++)
                    {
                        if (i != e.Index)
                        {
                            formas_de_pago.SetItemChecked(i, false);
                        }
                    }
                }
            }
        }
    }
}
