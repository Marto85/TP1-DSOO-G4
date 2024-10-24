
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            pictureBox1 = new PictureBox();
            username_login = new TextBox();
            password_login = new TextBox();
            Login_Button = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            mySqlCommand1 = new MySqlCommand();
            label1 = new Label();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sports_club_logo;
            pictureBox1.Location = new Point(61, 219);
            pictureBox1.Margin = new Padding(61, 219, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(379, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // username_login
            // 
            username_login.BackColor = Color.DimGray;
            username_login.BorderStyle = BorderStyle.None;
            username_login.Cursor = Cursors.Hand;
            username_login.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            username_login.ForeColor = Color.FromArgb(15, 15, 15);
            username_login.Location = new Point(641, 336);
            username_login.Margin = new Padding(7, 8, 7, 8);
            username_login.Name = "username_login";
            username_login.Size = new Size(928, 46);
            username_login.TabIndex = 2;
            username_login.Text = "Nombre de usuario";
            username_login.TextChanged += username_login_TextChanged;
            username_login.Enter += username_Enter;
            username_login.Leave += username_Leave;
            // 
            // password_login
            // 
            password_login.BackColor = Color.DimGray;
            password_login.BorderStyle = BorderStyle.None;
            password_login.Cursor = Cursors.Hand;
            password_login.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            password_login.ForeColor = Color.FromArgb(15, 15, 15);
            password_login.Location = new Point(641, 456);
            password_login.Margin = new Padding(7, 8, 7, 8);
            password_login.Name = "password_login";
            password_login.Size = new Size(928, 46);
            password_login.TabIndex = 3;
            password_login.Text = "Contraseña";
            password_login.TextChanged += password_login_TextChanged;
            password_login.Enter += password_Enter;
            password_login.Leave += password_Leave;
            // 
            // Login_Button
            // 
            Login_Button.BackColor = SystemColors.Highlight;
            Login_Button.Cursor = Cursors.Hand;
            Login_Button.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            Login_Button.FlatAppearance.BorderSize = 2;
            Login_Button.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Login_Button.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            Login_Button.FlatStyle = FlatStyle.Flat;
            Login_Button.Font = new Font("Century Gothic", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            Login_Button.ForeColor = SystemColors.InactiveCaptionText;
            Login_Button.Location = new Point(644, 659);
            Login_Button.Margin = new Padding(7, 8, 7, 8);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(928, 82);
            Login_Button.TabIndex = 1;
            Login_Button.Text = "ACCEDER";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Highlight;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(5, 5);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(500, 848);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.MouseDown += flowLayoutPanel1_MouseDown;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(736, 167);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(765, 70);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido a Club Sports";
            label1.Click += label1_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(1622, 0);
            btn_cerrar.Margin = new Padding(2, 3, 2, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(78, 55);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1547, 0);
            btn_minimizar.Margin = new Padding(2, 3, 2, 3);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(78, 55);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(btn_minimizar);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1695, 55);
            panel1.TabIndex = 9;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(15, 15, 15);
            panel2.Location = new Point(641, 380);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 11);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(15, 15, 15);
            panel3.Location = new Point(641, 503);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 11);
            panel3.TabIndex = 11;
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1707, 858);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Login_Button);
            Controls.Add(password_login);
            Controls.Add(username_login);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "Login_form";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            KeyPress += Login_Form_KeyPress;
            MouseDown += Login_form_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            if (this.verificarDatos(username_login.Text, password_login.Text))
            {
                this.Hide();
                Form formulario = new menu_form();
                formulario.ShowDialog();
                
            }
            else {

                MessageBox.Show("El nombre de usuario o la contraseña es incorrecto.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean verificarDatos(string username, string password)
        {
            conexion = Conexion.getInstancia();
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
        private TextBox username_login;
        private TextBox password_login;
        private Button Login_Button;
        private FlowLayoutPanel flowLayoutPanel1;
        private MySqlCommand mySqlCommand1;
        private Label label1;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}