﻿namespace DSOO_Grupo4_TP1
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            label1 = new Label();
            Nombre_Registro = new TextBox();
            Apellido_Registro = new TextBox();
            DNI_Registro = new TextBox();
            Telefono_Registro = new TextBox();
            Domicilio_Registro = new TextBox();
            Mail_Registro = new TextBox();
            Enviar_Registro = new Button();
            Socio = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 804);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 216);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btn_minimizar);
            panel2.Controls.Add(btn_cerrar);
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1729, 55);
            panel2.TabIndex = 11;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1586, 0);
            btn_minimizar.Margin = new Padding(2, 3, 2, 3);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(68, 46);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(1661, 0);
            btn_cerrar.Margin = new Padding(2, 3, 2, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(68, 46);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(789, 96);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(416, 46);
            label1.TabIndex = 0;
            label1.Text = "Registro de Clientes";
            label1.Click += label1_Click;
            // 
            // Nombre_Registro
            // 
            Nombre_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Nombre_Registro.Cursor = Cursors.Hand;
            Nombre_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Nombre_Registro.ForeColor = Color.Gray;
            Nombre_Registro.Location = new Point(544, 238);
            Nombre_Registro.Margin = new Padding(7, 8, 7, 8);
            Nombre_Registro.Name = "Nombre_Registro";
            Nombre_Registro.Size = new Size(380, 53);
            Nombre_Registro.TabIndex = 1;
            Nombre_Registro.Text = "Nombre";
            Nombre_Registro.TextChanged += Nombre_Registro_TextChanged;
            Nombre_Registro.Enter += Nombre_Registro_Enter;
            Nombre_Registro.Leave += Nombre_Registro_Leave;
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
            Apellido_Registro.Enter += Apellido_Registro_Enter;
            Apellido_Registro.Leave += Apellido_Registro_Leave;
            // 
            // DNI_Registro
            // 
            DNI_Registro.BackColor = Color.FromArgb(15, 15, 15);
            DNI_Registro.Cursor = Cursors.Hand;
            DNI_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            DNI_Registro.ForeColor = Color.Gray;
            DNI_Registro.Location = new Point(1020, 238);
            DNI_Registro.Margin = new Padding(7, 8, 7, 8);
            DNI_Registro.Name = "DNI_Registro";
            DNI_Registro.Size = new Size(380, 53);
            DNI_Registro.TabIndex = 5;
            DNI_Registro.Text = "DNI";
            DNI_Registro.Enter += DNI_Registro_Enter;
            DNI_Registro.Leave += DNI_Registro_Leave;
            // 
            // Telefono_Registro
            // 
            Telefono_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Telefono_Registro.Cursor = Cursors.Hand;
            Telefono_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Telefono_Registro.ForeColor = Color.Gray;
            Telefono_Registro.Location = new Point(1020, 325);
            Telefono_Registro.Margin = new Padding(7, 8, 7, 8);
            Telefono_Registro.Name = "Telefono_Registro";
            Telefono_Registro.Size = new Size(380, 53);
            Telefono_Registro.TabIndex = 6;
            Telefono_Registro.Text = "Telefono";
            Telefono_Registro.Enter += Telefono_Registro_Enter;
            Telefono_Registro.Leave += Telefono_Registro_Leave;
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
            Domicilio_Registro.Size = new Size(854, 53);
            Domicilio_Registro.TabIndex = 7;
            Domicilio_Registro.Text = "Domicilio";
            Domicilio_Registro.Enter += Domicilio_Registro_Enter;
            Domicilio_Registro.Leave += Domicilio_Registro_Leave;
            // 
            // Mail_Registro
            // 
            Mail_Registro.BackColor = Color.FromArgb(15, 15, 15);
            Mail_Registro.Cursor = Cursors.Hand;
            Mail_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            Mail_Registro.ForeColor = Color.Gray;
            Mail_Registro.Location = new Point(544, 519);
            Mail_Registro.Margin = new Padding(7, 8, 7, 8);
            Mail_Registro.Name = "Mail_Registro";
            Mail_Registro.Size = new Size(854, 53);
            Mail_Registro.TabIndex = 8;
            Mail_Registro.Text = "Correo Electronico";
            Mail_Registro.TextChanged += Mail_Registro_TextChanged;
            Mail_Registro.Enter += Mail_Registro_Enter;
            Mail_Registro.Leave += Mail_Registro_Leave;
            // 
            // Enviar_Registro
            // 
            Enviar_Registro.BackColor = Color.FromArgb(0, 122, 204);
            Enviar_Registro.Cursor = Cursors.Hand;
            Enviar_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Enviar_Registro.ForeColor = Color.FromArgb(15, 15, 15);
            Enviar_Registro.Location = new Point(741, 708);
            Enviar_Registro.Margin = new Padding(2, 3, 2, 3);
            Enviar_Registro.Name = "Enviar_Registro";
            Enviar_Registro.Size = new Size(503, 71);
            Enviar_Registro.TabIndex = 10;
            Enviar_Registro.Text = "Registrar";
            Enviar_Registro.UseVisualStyleBackColor = false;
            Enviar_Registro.Click += Enviar_Registro_Click;
            // 
            // Socio
            // 
            Socio.AutoSize = true;
            Socio.Location = new Point(544, 623);
            Socio.Margin = new Padding(7, 8, 7, 8);
            Socio.Name = "Socio";
            Socio.Size = new Size(129, 45);
            Socio.TabIndex = 12;
            Socio.Text = "Socio";
            Socio.UseVisualStyleBackColor = true;
            Socio.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AltaCliente_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1734, 804);
            Controls.Add(Socio);
            Controls.Add(panel2);
            Controls.Add(Enviar_Registro);
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "AltaCliente_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaCliente_Form";
            KeyPress += AltaCliente_Form_KeyPress;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
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
        private Button Enviar_Registro;
        private Panel panel2;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private CheckBox Socio;
    }
}