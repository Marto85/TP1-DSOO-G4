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
            Buscar_Cliente = new Button();
            DNI_Pagos = new TextBox();
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
            // Buscar_Cliente
            // 
            Buscar_Cliente.BackColor = SystemColors.Highlight;
            Buscar_Cliente.FlatStyle = FlatStyle.Flat;
            Buscar_Cliente.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Buscar_Cliente.Location = new Point(1313, 244);
            Buscar_Cliente.Margin = new Padding(7, 8, 7, 8);
            Buscar_Cliente.Name = "Buscar_Cliente";
            Buscar_Cliente.Size = new Size(385, 72);
            Buscar_Cliente.TabIndex = 17;
            Buscar_Cliente.Text = "Buscar";
            Buscar_Cliente.UseVisualStyleBackColor = false;
            // 
            // DNI_Pagos
            // 
            DNI_Pagos.BackColor = Color.FromArgb(15, 15, 15);
            DNI_Pagos.Cursor = Cursors.Hand;
            DNI_Pagos.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            DNI_Pagos.ForeColor = Color.Gray;
            DNI_Pagos.Location = new Point(692, 255);
            DNI_Pagos.Margin = new Padding(7, 8, 7, 8);
            DNI_Pagos.Name = "DNI_Pagos";
            DNI_Pagos.Size = new Size(380, 53);
            DNI_Pagos.TabIndex = 16;
            DNI_Pagos.Text = "DNI de cliente";
            // 
            // Pago_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1806, 901);
            Controls.Add(Buscar_Cliente);
            Controls.Add(DNI_Pagos);
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
        private Button Buscar_Cliente;
        private TextBox DNI_Pagos;
    }
}