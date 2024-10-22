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

        public string ImagenPerfil { get; set; }


        public Cliente(DateTime fechaIngreso, string nombre, string apellido, int dni, string direccion, string telefono, string email, string imagenPerfil, bool esSocio = false, bool esApto = true)
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
                            // El DNI ya existe en la base de datos
                            MessageBox.Show("Error: El cliente con este DNI ya existe.", "Error de duplicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;  // Detener el proceso de inserción
                        }
                    }


                    string query = @"INSERT INTO cliente 
                     (FechaIngreso, Nombre, Apellido, DNI, Direccion, Telefono, Email, EsSocio, EsApto, Imagen_Perfil) 
                     VALUES (@fechaIngreso, @nombre, @apellido, @dni, @direccion, @telefono, @email, @esSocio, @esApto, @imagen_Perfil)";

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

                        cmd.ExecuteNonQuery();
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

        public void ImprimirCarnet(Cliente cliente)
        {
            // Crear un nuevo objeto PrintDocument
            PrintDocument impresora = new PrintDocument();

            // Suscribir el evento PrintPage (donde se define qué imprimir)
            impresora.PrintPage += (sender, e) => GeneraCarnet(sender, e, cliente);

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
        }

        private void GeneraCarnet(object sender, PrintPageEventArgs e, Cliente cliente)
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
        }

    }

}
