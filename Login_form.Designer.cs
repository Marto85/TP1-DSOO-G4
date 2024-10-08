namespace DSOO_Grupo4_TP1
{
    partial class Login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            password.TabIndex = 2;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 401);
            Controls.Add(Login);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox username;
        private TextBox password;
        private Button Login;
    }
}