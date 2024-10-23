namespace DSOO_Grupo4_TP1.Forms
{
    partial class Carnet_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet_Form));
            panel2 = new Panel();
            Btn_Atras = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            pictureBoxPerfil = new PictureBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblSocio = new Label();
            Btn_Imprimir_Carnet = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(Btn_Atras);
            panel2.Controls.Add(btn_minimizar);
            panel2.Controls.Add(btn_cerrar);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 61);
            panel2.TabIndex = 12;
            // 
            // Btn_Atras
            // 
            Btn_Atras.Cursor = Cursors.Hand;
            Btn_Atras.Image = (Image)resources.GetObject("Btn_Atras.Image");
            Btn_Atras.Location = new Point(0, 0);
            Btn_Atras.Margin = new Padding(2, 3, 2, 3);
            Btn_Atras.Name = "Btn_Atras";
            Btn_Atras.Size = new Size(78, 55);
            Btn_Atras.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Atras.TabIndex = 13;
            Btn_Atras.TabStop = false;
            Btn_Atras.Click += Btn_Atras_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(747, 0);
            btn_minimizar.Margin = new Padding(2, 3, 2, 3);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(78, 55);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += Btn_minimizar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(829, 0);
            btn_cerrar.Margin = new Padding(2, 3, 2, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(78, 55);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += Btn_cerrar_Click;
            // 
            // pictureBoxPerfil
            // 
            pictureBoxPerfil.Location = new Point(43, 181);
            pictureBoxPerfil.Name = "pictureBoxPerfil";
            pictureBoxPerfil.Size = new Size(270, 250);
            pictureBoxPerfil.TabIndex = 13;
            pictureBoxPerfil.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(438, 181);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(97, 41);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "label1";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(695, 181);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(97, 41);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "label2";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(438, 377);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(97, 41);
            lblDNI.TabIndex = 16;
            lblDNI.Text = "label3";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(695, 377);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(97, 41);
            lblSocio.TabIndex = 17;
            lblSocio.Text = "label4";
            // 
            // Btn_Imprimir_Carnet
            // 
            Btn_Imprimir_Carnet.Location = new Point(508, 461);
            Btn_Imprimir_Carnet.Name = "Btn_Imprimir_Carnet";
            Btn_Imprimir_Carnet.Size = new Size(188, 58);
            Btn_Imprimir_Carnet.TabIndex = 18;
            Btn_Imprimir_Carnet.Text = "Imprimir";
            Btn_Imprimir_Carnet.UseVisualStyleBackColor = true;
            Btn_Imprimir_Carnet.Click += Btn_Imprimir_Carnet_Click;
            // 
            // Carnet_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 535);
            Controls.Add(Btn_Imprimir_Carnet);
            Controls.Add(lblSocio);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(pictureBoxPerfil);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Carnet_Form";
            Text = "Carnet_Form";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox Btn_Atras;
        private PictureBox btn_minimizar;
        private PictureBox btn_cerrar;
        private PictureBox pictureBoxPerfil;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblSocio;
        private Button Btn_Imprimir_Carnet;
    }
}