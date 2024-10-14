
using DSOO_Grupo4_TP1.Datos;
using System.Reflection;

namespace DSOO_Grupo4_TP1
{
    partial class menu_form : Form
    {
        private Conexion conexion;

        public menu_form(Conexion conexionActiva)
        {
            InitializeComponent();
            this.conexion = conexionActiva; // Guarda la conexión activa
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_form));
            AltaCliente = new Button();
            AltaSocio = new Button();
            ConvertirEnSocio = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            SuspendLayout();
            // 
            // AltaCliente
            // 
            AltaCliente.Location = new Point(199, 257);
            AltaCliente.Margin = new Padding(7, 8, 7, 8);
            AltaCliente.Name = "AltaCliente";
            AltaCliente.Size = new Size(369, 63);
            AltaCliente.TabIndex = 0;
            AltaCliente.Text = "Dar de alta un Cliente";
            AltaCliente.UseVisualStyleBackColor = true;
            AltaCliente.Click += AltaCliente_Click;
            // 
            // AltaSocio
            // 
            AltaSocio.Location = new Point(199, 372);
            AltaSocio.Margin = new Padding(7, 8, 7, 8);
            AltaSocio.Name = "AltaSocio";
            AltaSocio.Size = new Size(369, 63);
            AltaSocio.TabIndex = 1;
            AltaSocio.Text = "Dar de alta un Socio";
            AltaSocio.UseVisualStyleBackColor = true;
            AltaSocio.Click += AltaSocio_Click;
            // 
            // ConvertirEnSocio
            // 
            ConvertirEnSocio.Location = new Point(199, 489);
            ConvertirEnSocio.Margin = new Padding(7, 8, 7, 8);
            ConvertirEnSocio.Name = "ConvertirEnSocio";
            ConvertirEnSocio.Size = new Size(369, 63);
            ConvertirEnSocio.TabIndex = 2;
            ConvertirEnSocio.Text = "Convertir Cliente en Socio";
            ConvertirEnSocio.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(199, 599);
            button4.Margin = new Padding(7, 8, 7, 8);
            button4.Name = "button4";
            button4.Size = new Size(369, 63);
            button4.TabIndex = 3;
            button4.Text = "Inscribir en Actividad";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(665, 257);
            button5.Margin = new Padding(7, 8, 7, 8);
            button5.Name = "button5";
            button5.Size = new Size(369, 63);
            button5.TabIndex = 4;
            button5.Text = "Cobrar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = Color.RosyBrown;
            button6.Location = new Point(665, 489);
            button6.Margin = new Padding(7, 8, 7, 8);
            button6.Name = "button6";
            button6.Size = new Size(369, 63);
            button6.TabIndex = 5;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Location = new Point(665, 372);
            button7.Margin = new Padding(7, 8, 7, 8);
            button7.Name = "button7";
            button7.Size = new Size(369, 63);
            button7.TabIndex = 6;
            button7.Text = "Ver Morosos";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(btn_minimizar);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1548, 56);
            panel1.TabIndex = 7;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(1465, 6);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(69, 47);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 9;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1400, 6);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(69, 47);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 10;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // menu_form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1546, 800);
            Controls.Add(panel1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(ConvertirEnSocio);
            Controls.Add(AltaSocio);
            Controls.Add(AltaCliente);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "menu_form";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AltaCliente;
        private Button AltaSocio;
        private Button ConvertirEnSocio;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel panel1;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
    }
}