﻿
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
            ConvertirEnSocio = new Button();
            Inscribir_Actividad = new Button();
            button5 = new Button();
            Salir_Menu_Button = new Button();
            Morosos_Menu_Button = new Button();
            Menu_Form_Panel = new Panel();
            Btn_Atras = new PictureBox();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            Menu_Form_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            SuspendLayout();
            // 
            // AltaCliente
            // 
            AltaCliente.Location = new Point(82, 104);
            AltaCliente.Name = "AltaCliente";
            AltaCliente.Size = new Size(172, 23);
            AltaCliente.TabIndex = 0;
            AltaCliente.Text = "Dar de alta un socio o cliente";
            AltaCliente.UseVisualStyleBackColor = true;
            AltaCliente.Click += AltaCliente_Click;
            // 
            // ConvertirEnSocio
            // 
            ConvertirEnSocio.Location = new Point(82, 146);
            ConvertirEnSocio.Name = "ConvertirEnSocio";
            ConvertirEnSocio.Size = new Size(172, 23);
            ConvertirEnSocio.TabIndex = 2;
            ConvertirEnSocio.Text = "Convertir Cliente en Socio";
            ConvertirEnSocio.UseVisualStyleBackColor = true;
            ConvertirEnSocio.Click += ConvertirEnSocio_Click;
            // 
            // Inscribir_Actividad
            // 
            Inscribir_Actividad.Location = new Point(350, 104);
            Inscribir_Actividad.Name = "Inscribir_Actividad";
            Inscribir_Actividad.Size = new Size(172, 23);
            Inscribir_Actividad.TabIndex = 3;
            Inscribir_Actividad.Text = "Inscribir en Actividad";
            Inscribir_Actividad.UseVisualStyleBackColor = true;
            Inscribir_Actividad.Click += Inscribir_Actividad_Click;
            // 
            // button5
            // 
            button5.Location = new Point(350, 146);
            button5.Name = "button5";
            button5.Size = new Size(172, 23);
            button5.TabIndex = 4;
            button5.Text = "Cobrar";
            button5.UseVisualStyleBackColor = true;
            // 
            // Salir_Menu_Button
            // 
            Salir_Menu_Button.BackColor = Color.RosyBrown;
            Salir_Menu_Button.FlatStyle = FlatStyle.Flat;
            Salir_Menu_Button.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Salir_Menu_Button.Location = new Point(350, 236);
            Salir_Menu_Button.Name = "Salir_Menu_Button";
            Salir_Menu_Button.Size = new Size(171, 36);
            Salir_Menu_Button.TabIndex = 5;
            Salir_Menu_Button.Text = "Salir";
            Salir_Menu_Button.UseVisualStyleBackColor = false;
            Salir_Menu_Button.Click += Salir_Menu_Click;
            // 
            // Morosos_Menu_Button
            // 
            Morosos_Menu_Button.BackColor = Color.RosyBrown;
            Morosos_Menu_Button.FlatStyle = FlatStyle.Flat;
            Morosos_Menu_Button.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Morosos_Menu_Button.Location = new Point(76, 236);
            Morosos_Menu_Button.Name = "Morosos_Menu_Button";
            Morosos_Menu_Button.Size = new Size(172, 36);
            Morosos_Menu_Button.TabIndex = 6;
            Morosos_Menu_Button.Text = "Ver Morosos";
            Morosos_Menu_Button.UseVisualStyleBackColor = false;
            Morosos_Menu_Button.Click += Morosos_Menu_Button_Click;
            // 
            // Menu_Form_Panel
            // 
            Menu_Form_Panel.BackColor = SystemColors.Highlight;
            Menu_Form_Panel.Controls.Add(Btn_Atras);
            Menu_Form_Panel.Controls.Add(btn_cerrar);
            Menu_Form_Panel.Controls.Add(btn_minimizar);
            Menu_Form_Panel.Location = new Point(0, 1);
            Menu_Form_Panel.Margin = new Padding(1, 1, 1, 1);
            Menu_Form_Panel.Name = "Menu_Form_Panel";
            Menu_Form_Panel.Size = new Size(637, 23);
            Menu_Form_Panel.TabIndex = 7;
            Menu_Form_Panel.MouseDown += panel1_MouseDown;
            // 
            // Btn_Atras
            // 
            Btn_Atras.Image = (Image)resources.GetObject("Btn_Atras.Image");
            Btn_Atras.Location = new Point(5, 1);
            Btn_Atras.Margin = new Padding(1, 1, 1, 1);
            Btn_Atras.Name = "Btn_Atras";
            Btn_Atras.Size = new Size(32, 20);
            Btn_Atras.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Atras.TabIndex = 11;
            Btn_Atras.TabStop = false;
            Btn_Atras.Click += Btn_Atras_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(603, 2);
            btn_cerrar.Margin = new Padding(1, 1, 1, 1);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(32, 20);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 9;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(572, 2);
            btn_minimizar.Margin = new Padding(1, 1, 1, 1);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(32, 20);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 10;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // menu_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(637, 293);
            Controls.Add(Menu_Form_Panel);
            Controls.Add(Morosos_Menu_Button);
            Controls.Add(Salir_Menu_Button);
            Controls.Add(button5);
            Controls.Add(Inscribir_Actividad);
            Controls.Add(ConvertirEnSocio);
            Controls.Add(AltaCliente);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "menu_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu de Opciones";
            MouseDown += menu_form_MouseDown;
            Menu_Form_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AltaCliente;
        private Button ConvertirEnSocio;
        private Button Inscribir_Actividad;
        private Button button5;
        private Button Salir_Menu_Button;
        private Button Morosos_Menu_Button;
        private Panel Menu_Form_Panel;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private PictureBox Btn_Atras;
    }
}