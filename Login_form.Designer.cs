
using DSOO_Grupo4_TP1.Datos;
using DSOO_Grupo4_TP1.Models;
using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;

namespace DSOO_Grupo4_TP1
{
    partial class Login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Conexion conexion;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            username = new TextBox();
            password = new TextBox();
            Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sports_club_logo;
            pictureBox1.Location = new Point(63, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // username
            // 
            username.ForeColor = Color.Gray;
            username.Location = new Point(63, 231);
            username.Name = "username";
            username.Size = new Size(210, 23);
            username.TabIndex = 2;
            username.Text = "Nombre de usuario";
            username.TextChanged += textBox1_TextChanged;
            username.Enter += username_Enter;
            username.Leave += username_Leave;
            // 
            // password
            // 
            password.ForeColor = Color.Gray;
            password.Location = new Point(63, 278);
            password.Name = "password";
            password.Size = new Size(210, 23);
            password.TabIndex = 3;
            password.Text = "Contraseña";
            password.Enter += password_Enter;
            password.Leave += password_Leave;
            // 
            // Login
            // 
            Login.Location = new Point(63, 322);
            Login.Name = "Login";
            Login.Size = new Size(210, 23);
            Login.TabIndex = 1;
            Login.Text = "Ingresar";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 401);
            Controls.Add(Login);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(pictureBox1);
            Name = "Login_form";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            if (this.verificarDatos(username.Text, password.Text))
            {
                Form formulario = new menu_form();
                formulario.ShowDialog();
            }
            else {
                MessageBox.Show("El nombre de usuario o la contraseña es incorrecto.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean verificarDatos(string username, string password)
        {
            string connectionString = conexion.CrearConexion().ConnectionString; // Obtiene la cadena de conexión
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Abre la conexión
                    string query = "SELECT COUNT(*) FROM usuario WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Agregar parámetros para evitar inyecciones SQL
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Ejecuta la consulta y obtiene el resultado
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Devuelve verdadero si hay coincidencias, falso en caso contrario
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error en la conexión: " + ex.Message);
                    return false; // O maneja el error como prefieras
                }
                finally
                {
                    conn.Close(); // Cierra la conexión
                }
            }
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox username;
        private TextBox password;
        private Button Login;
    }
}