using DSOO_Grupo4_TP1.Datos;
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
    public partial class Inscribir_Actividad_Form : Form
    {

        private int id_usuario = -1;
        private bool esSocio = false;

        private Conexion conexion;
        public Inscribir_Actividad_Form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString; // Obtiene la cadena de conexión
            id_usuario = int.Parse(ID_Registro.Text); // Almacena el id del cliente
            esSocio = false; // Inicializa el estado del socio como falso

            if (id_usuario > 0)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT Nombre, Apellido, EsSocio FROM cliente WHERE Id = @id_usuario";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Definir el parámetro
                            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                            // Ejecuta la consulta y obtiene el resultado
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // Lee la primera fila del resultado
                                {
                                    string Nombre = reader.GetString("Nombre");
                                    string Apellido = reader.GetString("Apellido");
                                    esSocio = reader.GetBoolean("EsSocio"); // Almacena si es socio

                                    if (esSocio)
                                    {
                                        label1.Text = $"{Nombre} {Apellido} - es socio con abono. Puede inscribirse hasta en 3 actividades diferentes.";
                                    }
                                    else
                                    {
                                        label1.Text = $"{Nombre} {Apellido} - Paga por actividades individuales";
                                    }
                                }
                                else
                                {
                                    label1.Text = "No se ha encontrado el cliente con el ID indicado";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al conectarse a la base de datos: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void Inscripcion_Actividades_Button_Click(object sender, EventArgs e)
        {
            if (id_usuario == -1) // Verifica si el cliente fue buscado antes
            {
                MessageBox.Show("Primero debe buscar un cliente antes de inscribirlo en actividades.");
                return;
            }

            conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Obtener las actividades tildadas en los checkbox del form
                    List<int> actividadesSeleccionadas = ObtenerActividadesSeleccionadas();

                    // Verificar cuántas actividades ya tiene registradas el socio
                    int actividadesRegistradas = ObtenerCantidadActividadesRegistradas(conn, id_usuario);

                    // Para el caso de ser socio, se verifica cantidad de actividades en las que se quiere inscribir y en las que ya este inscripto para no superar el limite de 3
                    if (esSocio)
                    {
                        if (actividadesRegistradas + actividadesSeleccionadas.Count > 3)
                        {
                            MessageBox.Show("Un socio solo puede inscribirse en un máximo de 3 actividades.");
                            return;
                        }
                    }

                    // Registrar las actividades
                    RegistrarActividadesCliente(conn, id_usuario, esSocio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error durante la inscripción: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private List<int> ObtenerActividadesSeleccionadas()
        {
            List<int> actividadesSeleccionadas = new List<int>();

            // Agregar las actividades según los CheckBoxes seleccionados
            if (checkBoxYoga.Checked) actividadesSeleccionadas.Add(1);
            if (checkBoxPilates.Checked) actividadesSeleccionadas.Add(2);
            if (checkBoxZumba.Checked) actividadesSeleccionadas.Add(3);
            if (checkBoxCrossfit.Checked) actividadesSeleccionadas.Add(4); 
            if (checkBoxNatacion.Checked) actividadesSeleccionadas.Add(5);
            if (checkBoxFutbol.Checked) actividadesSeleccionadas.Add(6);

            return actividadesSeleccionadas;
        }

        private int ObtenerCantidadActividadesRegistradas(MySqlConnection conn, int idCliente)
        {
            string query = "SELECT COUNT(*) FROM Actividad_Cliente WHERE IdCliente = @idCliente";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


        private void RegistrarActividadesCliente(MySqlConnection conn, int idCliente, bool esSocio)
        {
            List<int> actividadesSeleccionadas = ObtenerActividadesSeleccionadas();

            // Verifica si hay cupos disponibles antes de inscribir
            foreach (int idActividad in actividadesSeleccionadas)
            {
                string queryCupos = "SELECT CuposDisponibles FROM Actividad WHERE Id = @idActividad";
                using (MySqlCommand cmdCupos = new MySqlCommand(queryCupos, conn))
                {
                    cmdCupos.Parameters.AddWithValue("@idActividad", idActividad);
                    int cuposDisponibles = Convert.ToInt32(cmdCupos.ExecuteScalar());

                    if (cuposDisponibles <= 0)
                    {
                        MessageBox.Show($"No hay cupos disponibles para la actividad con Id {idActividad}");
                        return;
                    }
                }
            }

            // Insertar la inscripción en la tabla Actividad_Cliente
            foreach (int idActividad in actividadesSeleccionadas)
            {
                string queryInscribir = "INSERT INTO Actividad_Cliente (IdCliente, IdActividad, EsSocio) VALUES (@IdCliente, @IdActividad, @EsSocio)";
                using (MySqlCommand cmdInscribir = new MySqlCommand(queryInscribir, conn))
                {
                    cmdInscribir.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmdInscribir.Parameters.AddWithValue("@IdActividad", idActividad);
                    cmdInscribir.Parameters.AddWithValue("@EsSocio", esSocio ? 1 : 0);
                    cmdInscribir.ExecuteNonQuery();

                    // Actualiza cupos disponibles en las actividades a las cuales se inscribio el cliente
                    string queryReducirCupos = "UPDATE Actividad SET CuposDisponibles = CuposDisponibles - 1 WHERE Id = @idActividad";
                    using (MySqlCommand cmdReducirCupos = new MySqlCommand(queryReducirCupos, conn))
                    {
                        cmdReducirCupos.Parameters.AddWithValue("@idActividad", idActividad);
                        cmdReducirCupos.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Cliente inscripto correctamente en las actividades seleccionadas.");
        }


    }
}
