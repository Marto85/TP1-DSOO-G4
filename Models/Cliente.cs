using DSOO_Grupo4_TP1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSOO_Grupo4_TP1.Models
{
    public class Cliente
    {
        public int IdCliente { get; private set; }
        public DateTime FechaIngreso { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool EsSocio { get; set; }
        public bool EsApto { get; set; }

        public decimal AbonoMensualSocios { get; set; }

        public string ImagenPerfil { get; set; }

        private List<Cliente> listaDeClientes = new List<Cliente>();


        public Cliente(DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, string imagenPerfil, decimal? abonoMensualSocios = null, bool esSocio = false, bool esApto = true)
        {
            FechaIngreso = fechaIngreso;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            EsSocio = esSocio;
            EsApto = esApto;
            ImagenPerfil = imagenPerfil;

            // Solo asignar abono si es un socio
            if (esSocio && abonoMensualSocios.HasValue)
            {
                AbonoMensualSocios = abonoMensualSocios.Value;
            }
        }

        public decimal GetAbonoMensualSocios()
        {
            return AbonoMensualSocios;
        }

        public void SetAbonoMensualSocios(decimal abonoMensualSocios)
        {
            AbonoMensualSocios = abonoMensualSocios;
        }

        public void AltaCliente()
        {
            Conexion conexion = Conexion.getInstancia();

            using (MySqlConnection conn = conexion.CrearConexion())
            {
              
                try
                {
                    conn.Open();

                    // Verificar si el DNI ya existe
                    string checkQuery = "SELECT COUNT(*) FROM cliente WHERE DNI = @dni";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@dni", DNI);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Error: El cliente con este DNI ya existe.", "Error de duplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }
                    }

                    // Definir el query según si es socio o no
                    string query = @"INSERT INTO cliente 
                (FechaIngreso, Nombre, Apellido, DNI, Direccion, Telefono, Email, EsSocio, EsApto, Imagen_Perfil";

                    if (EsSocio)
                    {
                        query += ", AbonoMensualSocios";
                    }

                    query += ") VALUES (@fechaIngreso, @nombre, @apellido, @dni, @direccion, @telefono, @email, @esSocio, @esApto, @imagen_Perfil";

                    if (EsSocio)
                    {
                        query += ", @abonoMensualSocios";
                    }

                    query += ")";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@fechaIngreso", FechaIngreso);
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@dni", DNI);
                        cmd.Parameters.AddWithValue("@direccion", Direccion);
                        cmd.Parameters.AddWithValue("@telefono", Telefono);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@esSocio", EsSocio);
                        cmd.Parameters.AddWithValue("@esApto", EsApto);
                        cmd.Parameters.AddWithValue("@imagen_Perfil", ImagenPerfil);

                        if (EsSocio)
                        {
                            cmd.Parameters.AddWithValue("@abonoMensualSocios", GetAbonoMensualSocios());
                        }

                        cmd.ExecuteNonQuery();

                        // Obtener el ID del cliente recién insertado
                        MySqlCommand getIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn);
                        int idGenerado = Convert.ToInt32(getIdCmd.ExecuteScalar());
                        this.IdCliente = idGenerado; 

                        if (EsSocio)
                        {
                            MessageBox.Show("Socio registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show($"Se procede a entregar al Socio con nombre {Nombre} {Apellido} el carnet que lo acredita como socio de Club Sports");
                        }
                        else {
                            MessageBox.Show("Cliente registrado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show($"Se procede a entregar al Cliente con nombre {Nombre} {Apellido} el carnet que lo acredita a ingresar a las actividades.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"{ImagenPerfil}Error al registrar cliente: {ex.Message}\nCódigo del error: {ex.Number}");
                }

            }
        }

        public void RegistrarPagoSocio(int clienteId, int mesesAbonados)
        {
            Conexion conexion = Conexion.getInstancia();
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();

                    decimal monto = 10000; // Precio mensual base
                    DateTime fechaPago = DateTime.Now;
                    DateTime proximoVencimiento = fechaPago;

                    // Cálculo del monto total según la cantidad de meses abonados
                    switch (mesesAbonados)
                    {
                        case 1:
                            monto = 10000; // Sin descuento
                            proximoVencimiento = fechaPago.AddMonths(1);
                            break;
                        case 3:
                            monto = 9500 * 3; // Descuento por 3 meses
                            proximoVencimiento = fechaPago.AddMonths(3);
                            break;
                        case 6:
                            monto = 8700 * 6; // Descuento por 6 meses
                            proximoVencimiento = fechaPago.AddMonths(6);
                            break;
                        case 12:
                            monto = 7500 * 12; // Descuento por 12 meses
                            proximoVencimiento = fechaPago.AddMonths(12);
                            break;
                        default:
                            MessageBox.Show("Cantidad de meses no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Insertar el pago en la tabla 'Pago'
                    string query = @"INSERT INTO pago (Cliente_Id, Monto, FechaPago, ProximoVencimiento, Id_tipo_de_pago) 
                             VALUES (@clienteId, @monto, @fechaPago, @proximoVencimiento, @idTipoPago)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@clienteId", clienteId);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                        cmd.Parameters.AddWithValue("@proximoVencimiento", proximoVencimiento);
                        cmd.Parameters.AddWithValue("@idTipoPago", 1); // Asumimos que 1 es "Abono general"

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Pago registrado exitosamente. Total: {monto:C2}. Vencimiento: {proximoVencimiento.ToShortDateString()}",
                            "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al registrar pago: {ex.Message}\nCódigo del error: {ex.Number}");
                }
            }
        }


        public void RegistrarPagoNoSocio(int clienteId, int actividadId, string duracion)
        {
            Conexion conexion = Conexion.getInstancia();
            using (MySqlConnection conn = conexion.CrearConexion())
            {
                try
                {
                    conn.Open();

                    // Obtener el precio mensual de la actividad
                    string getPrecioQuery = "SELECT PrecioNoSocio FROM actividad WHERE Id = @actividadId";
                    decimal precioMensual = 0;

                    using (MySqlCommand getPrecioCmd = new MySqlCommand(getPrecioQuery, conn))
                    {
                        getPrecioCmd.Parameters.AddWithValue("@actividadId", actividadId);
                        precioMensual = Convert.ToDecimal(getPrecioCmd.ExecuteScalar());
                    }

                    decimal monto = 0;
                    DateTime fechaPago = DateTime.Now;
                    DateTime proximoVencimiento = fechaPago;

                    // Cálculo del monto según la duración del pago
                    switch (duracion.ToLower())
                    {
                        case "semanal":
                            monto = (precioMensual / 4) * 1.05m; // Recargo del 5%
                            proximoVencimiento = fechaPago.AddDays(7);
                            break;
                        case "quincenal":
                            monto = (precioMensual / 2) * 1.10m; // Recargo del 10%
                            proximoVencimiento = fechaPago.AddDays(14);
                            break;
                        case "mensual":
                            monto = precioMensual;
                            proximoVencimiento = fechaPago.AddMonths(1);
                            break;
                        case "6 meses":
                            monto = (precioMensual * 6) * 0.90m; // Descuento del 10%
                            proximoVencimiento = fechaPago.AddMonths(6);
                            break;
                        case "12 meses":
                            monto = (precioMensual * 12) * 0.80m; // Descuento del 20%
                            proximoVencimiento = fechaPago.AddMonths(12);
                            break;
                        default:
                            MessageBox.Show("Duración no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Insertar el pago en la tabla 'Pago_Actividad'
                    string query = @"INSERT INTO pago_actividad (Cliente_Id, Actividad_Id, Monto, FechaPago, ProximoVencimiento) 
                             VALUES (@clienteId, @actividadId, @monto, @fechaPago, @proximoVencimiento)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@clienteId", clienteId);
                        cmd.Parameters.AddWithValue("@actividadId", actividadId);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@fechaPago", fechaPago);
                        cmd.Parameters.AddWithValue("@proximoVencimiento", proximoVencimiento);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Pago registrado exitosamente. Total: {monto:C2}. Vencimiento: {proximoVencimiento.ToShortDateString()}",
                            "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al registrar pago: {ex.Message}\nCódigo del error: {ex.Number}");
                }
            }
        }

        private int ObtenerTipoDePagoId(int meses)
        {
            switch (meses)
            {
                case 1: return 3;  // Mensual
                case 3: return 4;  // Trimestral
                case 6: return 5;  // Semestral
                case 12: return 6; // Anual
                default: throw new ArgumentException("Duración de abono inválida.");
            }
        }

        /*public void ImprimirCarnet(Cliente cliente)
        {
            // Crear un nuevo objeto PrintDocument
            PrintDocument impresora = new PrintDocument();

            // Suscribir el evento PrintPage (donde se define qué imprimir)
            impresora.PrintPage += (sender, e) => GenerarCarnet(sender, e, cliente);

            // Crear un cuadro de diálogo de impresión
            PrintDialog printDialog = new PrintDialog
            {
                Document = impresora
            };

            // Abrir el cuadro de diálogo de impresión
            DialogResult result = printDialog.ShowDialog();

            // Si el usuario hace clic en "Imprimir", realizar la impresión
            if (result == DialogResult.OK)
            {
                impresora.Print();
            }
        }*/

        /*private void GenerarCarnet(object sender, PrintPageEventArgs e, Cliente cliente)
        {
            // Definir las fuentes y estructura de lo que se va a imprimir
            Font fuenteTitulo = new Font("Arial", 16, FontStyle.Bold);
            Font fuenteNormal = new Font("Arial", 12, FontStyle.Regular);

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float lineHeight = fuenteNormal.GetHeight(e.Graphics) + 5;

            // Título del documento
            e.Graphics.DrawString("Datos del Cliente", fuenteTitulo, Brushes.Black, x, y);
            y += lineHeight * 2;

            // Imprimir los detalles del cliente
            e.Graphics.DrawString($"Nombre: {cliente.Nombre} {cliente.Apellido}", fuenteNormal, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"DNI: {cliente.DNI}", fuenteNormal, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Fecha de Ingreso: {cliente.FechaIngreso.ToShortDateString()}", fuenteNormal, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Dirección: {cliente.Direccion}", fuenteNormal, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Teléfono: {cliente.Telefono}", fuenteNormal, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Email: {cliente.Email}", fuenteNormal, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Es Socio: {(cliente.EsSocio ? "Sí" : "No")}", fuenteNormal, Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString($"Es Apto: {(cliente.EsApto ? "Sí" : "No")}", fuenteNormal, Brushes.Black, x, y);
            y += lineHeight;

            // Si la imagen está presente, también podrías incluirla en la impresión
            if (!string.IsNullOrEmpty(cliente.ImagenPerfil) && System.IO.File.Exists(cliente.ImagenPerfil))
            {
                Image imagen = Image.FromFile(cliente.ImagenPerfil);
                e.Graphics.DrawImage(imagen, x, y, 100, 100); // Dibuja la imagen en un tamaño de 100x100
            }
        }*/

    }

}
