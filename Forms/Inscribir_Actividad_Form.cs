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
    public partial class Inscribir_Actividad_Form : Form
    {

        private int id_usuario = -1;
        private bool esSocio = false;
        private Conexion conexion;
        private Form _formularioPrincipal;
        private Cliente cliente;

        public Inscribir_Actividad_Form(Form formularioPrincipal)
        {
            InitializeComponent();
            this.AcceptButton = Inscripcion_Actividades_Button;
            _formularioPrincipal = formularioPrincipal;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Utils.ConfirmarCierre();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            int dni_usuario = int.Parse(DNI_Registro.Text); // Almacena el dni del cliente
            if (dni_usuario > 0)
            {
                try { 
                    cliente = new Cliente(dni_usuario);

                    id_usuario = cliente.IdCliente; // Almacena el id del cliente
                    string Nombre = cliente.Nombre;
                    string Apellido = cliente.Apellido;

                    if (cliente.EsSocio) label1.Text = $"{Nombre} {Apellido} - es socio con abono. Puede inscribirse hasta en 3 actividades diferentes.";
                    else label1.Text = $"{Nombre} {Apellido} - Paga por actividades individuales";

                    ToggleVisibleFields(true);

                    if (id_usuario > 0) ObtenerActividadesRegistradas(id_usuario);

                } catch {

                    label1.Text = "No se ha encontrado el cliente con el DNI indicado";
                    ToggleVisibleFields(false);
                    id_usuario = -1;
                }
            }
            else {
                label1.Text = "No se ha encontrado el cliente con el DNI indicado";
                ToggleVisibleFields(false);
                id_usuario = -1;
            }
            
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        }

        private void ToggleVisibleFields(bool value) {
            this.label2.Visible = value;
            this.checkBoxCrossfit.Visible = value;
            this.checkBoxFutbol.Visible = value;
            this.checkBoxNatacion.Visible = value;
            this.checkBoxPilates.Visible = value;
            this.checkBoxYoga.Visible = value;
            this.checkBoxZumba.Visible = value;
            this.Inscripcion_Actividades_Button.Visible = value;
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
                    if (cliente.EsSocio)
                    {
                        if (actividadesRegistradas + actividadesSeleccionadas.Count > 3)
                        {
                            MessageBox.Show("Un socio solo puede inscribirse en un máximo de 3 actividades.");
                            return;
                        }
                    }

                    // Registrar las actividades
                    RegistrarActividadesCliente(conn, cliente.IdCliente, cliente.EsSocio);
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

        private void TildarActividad(int actividadId, bool value) {
            switch (actividadId)
            {
                case 1: checkBoxYoga.Checked = value; break;
                case 2: checkBoxPilates.Checked = value; break;
                case 3: checkBoxZumba.Checked = value; break;
                case 4: checkBoxCrossfit.Checked = value; break;
                case 5: checkBoxNatacion.Checked = value; break;
                case 6: checkBoxFutbol.Checked = value; break;
            }
        }

        private void ObtenerActividadesRegistradas(int IdCliente)
        {
            conexion = Conexion.getInstancia();
            string connectionString = conexion.CrearConexion().ConnectionString; // Obtiene la cadena de conexión           

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Actividad_Cliente WHERE IdCliente = @IdCliente";
                    // Destildar todos los checkboxes antes de leer los datos
                    checkBoxYoga.Checked = false;
                    checkBoxPilates.Checked = false;
                    checkBoxZumba.Checked = false;
                    checkBoxCrossfit.Checked = false;
                    checkBoxNatacion.Checked = false;
                    checkBoxFutbol.Checked = false;

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", IdCliente);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int actividadId = reader.GetInt32("IdActividad");
                                TildarActividad(actividadId, true);
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

            // Obtén todas las relaciones actuales del cliente con las actividades
            string queryRelacionesExistentes = "SELECT IdActividad FROM Actividad_Cliente WHERE IdCliente = @IdCliente";
            List<int> actividadesRelacionadas = new List<int>();
            using (MySqlCommand cmdRelaciones = new MySqlCommand(queryRelacionesExistentes, conn))
            {
                cmdRelaciones.Parameters.AddWithValue("@IdCliente", idCliente);
                using (MySqlDataReader reader = cmdRelaciones.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        actividadesRelacionadas.Add(reader.GetInt32("IdActividad"));
                    }
                }
            }

            // Procesar actividades seleccionadas y relaciones existentes
            foreach (int idActividad in actividadesRelacionadas)
            {
                // Si no está seleccionada y existe la relación, eliminarla
                if (!actividadesSeleccionadas.Contains(idActividad))
                {
                    string queryEliminar = "DELETE FROM Actividad_Cliente WHERE IdCliente = @IdCliente AND IdActividad = @IdActividad";
                    using (MySqlCommand cmdEliminar = new MySqlCommand(queryEliminar, conn))
                    {
                        cmdEliminar.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmdEliminar.Parameters.AddWithValue("@IdActividad", idActividad);
                        cmdEliminar.ExecuteNonQuery();
                    }

                    // Incrementar cupos disponibles
                    string queryIncrementarCupos = "UPDATE Actividad SET CuposDisponibles = CuposDisponibles + 1 WHERE Id = @idActividad";
                    using (MySqlCommand cmdIncrementarCupos = new MySqlCommand(queryIncrementarCupos, conn))
                    {
                        cmdIncrementarCupos.Parameters.AddWithValue("@idActividad", idActividad);
                        cmdIncrementarCupos.ExecuteNonQuery();
                    }
                }
            }

            foreach (int idActividad in actividadesSeleccionadas)
            {
                // Si está seleccionada pero no existe la relación, crearla
                if (!actividadesRelacionadas.Contains(idActividad))
                {
                    // Verificar cupos antes de inscribir
                    string queryCupos = "SELECT CuposDisponibles FROM Actividad WHERE Id = @idActividad";
                    using (MySqlCommand cmdCupos = new MySqlCommand(queryCupos, conn))
                    {
                        cmdCupos.Parameters.AddWithValue("@idActividad", idActividad);
                        int cuposDisponibles = Convert.ToInt32(cmdCupos.ExecuteScalar());

                        if (cuposDisponibles <= 0)
                        {
                            MessageBox.Show($"No hay cupos disponibles para la actividad con Id {idActividad}, se procederá con las siguientes");
                            TildarActividad(idActividad, false);
                            continue;
                        }
                    }

                    // Insertar inscripción
                    string queryInscribir = "INSERT INTO Actividad_Cliente (IdCliente, IdActividad, EsSocio) VALUES (@IdCliente, @IdActividad, @EsSocio)";
                    using (MySqlCommand cmdInscribir = new MySqlCommand(queryInscribir, conn))
                    {
                        cmdInscribir.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmdInscribir.Parameters.AddWithValue("@IdActividad", idActividad);
                        cmdInscribir.Parameters.AddWithValue("@EsSocio", esSocio ? 1 : 0);
                        cmdInscribir.ExecuteNonQuery();
                    }

                    // Reducir cupos disponibles
                    string queryReducirCupos = "UPDATE Actividad SET CuposDisponibles = CuposDisponibles - 1 WHERE Id = @idActividad";
                    using (MySqlCommand cmdReducirCupos = new MySqlCommand(queryReducirCupos, conn))
                    {
                        cmdReducirCupos.Parameters.AddWithValue("@idActividad", idActividad);
                        cmdReducirCupos.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Proceso completado: inscripciones actualizadas correctamente.");
        }



        private void ID_Registro_Enter(object sender, EventArgs e)
        {
            if (DNI_Registro.Text == "ID de cliente")
            {
                DNI_Registro.Text = "";
                DNI_Registro.ForeColor = Color.White;
            }
        }

        private void ID_Registro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DNI_Registro.Text))
            {
                DNI_Registro.Text = "ID de cliente";
                DNI_Registro.ForeColor = Color.DarkGray;
            }
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

        private void Inscribir_Actividad_Form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
