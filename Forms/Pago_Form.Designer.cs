namespace DSOO_Grupo4_TP1.Forms
{
    partial class Pago_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago_Form));
            panel2 = new Panel();
            Btn_Atras = new PictureBox();
            Btn_minimizar = new PictureBox();
            Btn_cerrar = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_cerrar).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(Btn_Atras);
            panel2.Controls.Add(Btn_minimizar);
            panel2.Controls.Add(Btn_cerrar);
            panel2.Location = new Point(0, 2);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1803, 55);
            panel2.TabIndex = 12;
            // 
            // Btn_Atras
            // 
            Btn_Atras.Cursor = Cursors.Hand;
            Btn_Atras.Image = (Image)resources.GetObject("Btn_Atras.Image");
            Btn_Atras.Location = new Point(2, -3);
            Btn_Atras.Margin = new Padding(2, 3, 2, 3);
            Btn_Atras.Name = "Btn_Atras";
            Btn_Atras.Size = new Size(78, 55);
            Btn_Atras.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Atras.TabIndex = 13;
            Btn_Atras.TabStop = false;
            Btn_Atras.Click += Btn_Atras_Click;
            // 
            // Btn_minimizar
            // 
            Btn_minimizar.Cursor = Cursors.Hand;
            Btn_minimizar.Image = (Image)resources.GetObject("Btn_minimizar.Image");
            Btn_minimizar.Location = new Point(1643, -3);
            Btn_minimizar.Margin = new Padding(2, 3, 2, 3);
            Btn_minimizar.Name = "Btn_minimizar";
            Btn_minimizar.Size = new Size(78, 55);
            Btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_minimizar.TabIndex = 8;
            Btn_minimizar.TabStop = false;
            Btn_minimizar.Click += Btn_minimizar_Click;
            // 
            // Btn_cerrar
            // 
            Btn_cerrar.Cursor = Cursors.Hand;
            Btn_cerrar.Image = (Image)resources.GetObject("Btn_cerrar.Image");
            Btn_cerrar.Location = new Point(1725, -3);
            Btn_cerrar.Margin = new Padding(2, 3, 2, 3);
            Btn_cerrar.Name = "Btn_cerrar";
            Btn_cerrar.Size = new Size(78, 55);
            Btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_cerrar.TabIndex = 7;
            Btn_cerrar.TabStop = false;
            Btn_cerrar.Click += Btn_cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(664, 114);
            label1.Name = "label1";
            label1.Size = new Size(429, 56);
            label1.TabIndex = 13;
            label1.Text = "Registro de Pagos";
            // 
            // Pago_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1806, 901);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pago_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago_Form";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox Btn_Atras;
        private PictureBox Btn_minimizar;
        private PictureBox Btn_cerrar;
        private Label label1;
    }
}