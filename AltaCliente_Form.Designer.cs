namespace DSOO_Grupo4_TP1
{
    partial class AltaCliente_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCliente_Form));
            panel1 = new Panel();
            panel2 = new Panel();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Nombre_Registro = new TextBox();
            Apellido_Registro = new TextBox();
            DNI_Registro = new TextBox();
            Telefono_Registro = new TextBox();
            Domicilio_Registro = new TextBox();
            Mail_Registro = new TextBox();
            Tipo_Cliente_Registro = new ComboBox();
            Enviar_Registro = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 803);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btn_minimizar);
            panel2.Controls.Add(btn_cerrar);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1730, 56);
            panel2.TabIndex = 11;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(1661, 0);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(69, 47);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1586, 0);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(69, 47);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(789, 95);
            label1.Name = "label1";
            label1.Size = new Size(416, 46);
            label1.TabIndex = 1;
            label1.Text = "Registro de Clientes";
            label1.Click += label1_Click;
            // 
            // Nombre_Registro
            // 
            Nombre_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Nombre_Registro.Cursor = Cursors.Hand;
            Nombre_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Nombre_Registro.ForeColor = Color.Gray;
            Nombre_Registro.Location = new Point(544, 237);
            Nombre_Registro.Margin = new Padding(7, 8, 7, 8);
            Nombre_Registro.Name = "Nombre_Registro";
            Nombre_Registro.Size = new Size(380, 53);
            Nombre_Registro.TabIndex = 3;
            Nombre_Registro.Text = "Nombre";
            // 
            // Apellido_Registro
            // 
            Apellido_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Apellido_Registro.Cursor = Cursors.Hand;
            Apellido_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Apellido_Registro.ForeColor = Color.Gray;
            Apellido_Registro.Location = new Point(544, 325);
            Apellido_Registro.Margin = new Padding(7, 8, 7, 8);
            Apellido_Registro.Name = "Apellido_Registro";
            Apellido_Registro.Size = new Size(380, 53);
            Apellido_Registro.TabIndex = 4;
            Apellido_Registro.Text = "Apellido";
            // 
            // DNI_Registro
            // 
            DNI_Registro.BackColor = Color.FromArgb(15, 15, 15);
            DNI_Registro.Cursor = Cursors.Hand;
            DNI_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            DNI_Registro.ForeColor = Color.Gray;
            DNI_Registro.Location = new Point(1019, 237);
            DNI_Registro.Margin = new Padding(7, 8, 7, 8);
            DNI_Registro.Name = "DNI_Registro";
            DNI_Registro.Size = new Size(380, 53);
            DNI_Registro.TabIndex = 5;
            DNI_Registro.Text = "DNI";
            // 
            // Telefono_Registro
            // 
            Telefono_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Telefono_Registro.Cursor = Cursors.Hand;
            Telefono_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Telefono_Registro.ForeColor = Color.Gray;
            Telefono_Registro.Location = new Point(1019, 325);
            Telefono_Registro.Margin = new Padding(7, 8, 7, 8);
            Telefono_Registro.Name = "Telefono_Registro";
            Telefono_Registro.Size = new Size(380, 53);
            Telefono_Registro.TabIndex = 6;
            Telefono_Registro.Text = "Telefono";
            // 
            // Domicilio_Registro
            // 
            Domicilio_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Domicilio_Registro.Cursor = Cursors.Hand;
            Domicilio_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Domicilio_Registro.ForeColor = Color.Gray;
            Domicilio_Registro.Location = new Point(544, 421);
            Domicilio_Registro.Margin = new Padding(7, 8, 7, 8);
            Domicilio_Registro.Name = "Domicilio_Registro";
            Domicilio_Registro.Size = new Size(855, 53);
            Domicilio_Registro.TabIndex = 7;
            Domicilio_Registro.Text = "Domicilio";
            // 
            // Mail_Registro
            // 
            Mail_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Mail_Registro.Cursor = Cursors.Hand;
            Mail_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Mail_Registro.ForeColor = Color.Gray;
            Mail_Registro.Location = new Point(544, 518);
            Mail_Registro.Margin = new Padding(7, 8, 7, 8);
            Mail_Registro.Name = "Mail_Registro";
            Mail_Registro.Size = new Size(855, 53);
            Mail_Registro.TabIndex = 8;
            Mail_Registro.Text = "Correo Electronico";
            Mail_Registro.TextChanged += Mail_Registro_TextChanged;
            // 
            // Tipo_Cliente_Registro
            // 
            Tipo_Cliente_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Tipo_Cliente_Registro.Cursor = Cursors.Hand;
            Tipo_Cliente_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Tipo_Cliente_Registro.ForeColor = Color.Gray;
            Tipo_Cliente_Registro.FormattingEnabled = true;
            Tipo_Cliente_Registro.Items.AddRange(new object[] { "Seleccione una opcion:", "Es Socio", "Cliente por actividades" });
            Tipo_Cliente_Registro.Location = new Point(544, 613);
            Tipo_Cliente_Registro.Name = "Tipo_Cliente_Registro";
            Tipo_Cliente_Registro.Size = new Size(855, 52);
            Tipo_Cliente_Registro.TabIndex = 9;
            Tipo_Cliente_Registro.SelectedIndexChanged += Tipo_Cliente_Form_SelectedIndexChanged;
            // 
            // Enviar_Registro
            // 
            Enviar_Registro.BackColor = Color.FromArgb(0, 122, 204);
            Enviar_Registro.Cursor = Cursors.Hand;
            Enviar_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Enviar_Registro.ForeColor = Color.FromArgb(15, 15, 15);
            Enviar_Registro.Location = new Point(741, 707);
            Enviar_Registro.Name = "Enviar_Registro";
            Enviar_Registro.Size = new Size(502, 70);
            Enviar_Registro.TabIndex = 10;
            Enviar_Registro.Text = "Registrar";
            Enviar_Registro.UseVisualStyleBackColor = false;
            Enviar_Registro.Click += Enviar_Registro_Click;
            // 
            // AltaCliente_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1735, 803);
            Controls.Add(panel2);
            Controls.Add(Enviar_Registro);
            Controls.Add(Tipo_Cliente_Registro);
            Controls.Add(Mail_Registro);
            Controls.Add(Domicilio_Registro);
            Controls.Add(Telefono_Registro);
            Controls.Add(DNI_Registro);
            Controls.Add(Apellido_Registro);
            Controls.Add(Nombre_Registro);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaCliente_Form";
            Text = "AltaCliente_Form";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox Nombre_Registro;
        private TextBox Apellido_Registro;
        private TextBox DNI_Registro;
        private TextBox Telefono_Registro;
        private TextBox Domicilio_Registro;
        private TextBox Mail_Registro;
        private ComboBox Tipo_Cliente_Registro;
        private Button Enviar_Registro;
        private Panel panel2;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
    }
}