namespace DSOO_Grupo4_TP1.Forms
{
    partial class ClientesMorosos_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesMorosos_Form));
            panel2 = new Panel();
            Btn_Atras = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            dgvClientesVencidos = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesVencidos).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(Btn_Atras);
            panel2.Controls.Add(btn_minimizar);
            panel2.Controls.Add(btn_cerrar);
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(1, 1, 1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 20);
            panel2.TabIndex = 12;
            // 
            // Btn_Atras
            // 
            Btn_Atras.Cursor = Cursors.Hand;
            Btn_Atras.Image = (Image)resources.GetObject("Btn_Atras.Image");
            Btn_Atras.Location = new Point(1, 0);
            Btn_Atras.Margin = new Padding(1, 1, 1, 1);
            Btn_Atras.Name = "Btn_Atras";
            Btn_Atras.Size = new Size(32, 20);
            Btn_Atras.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Atras.TabIndex = 13;
            Btn_Atras.TabStop = false;
            Btn_Atras.Click += Btn_Atras_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(912, 0);
            btn_minimizar.Margin = new Padding(1, 1, 1, 1);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(32, 20);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(940, 0);
            btn_cerrar.Margin = new Padding(1, 1, 1, 1);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(32, 20);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // dgvClientesVencidos
            // 
            dgvClientesVencidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesVencidos.Location = new Point(26, 59);
            dgvClientesVencidos.Margin = new Padding(1, 1, 1, 1);
            dgvClientesVencidos.Name = "dgvClientesVencidos";
            dgvClientesVencidos.RowHeadersWidth = 102;
            dgvClientesVencidos.RowTemplate.Height = 49;
            dgvClientesVencidos.Size = new Size(744, 203);
            dgvClientesVencidos.TabIndex = 14;
            // 
            // ClientesMorosos_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 382);
            Controls.Add(dgvClientesVencidos);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1, 1, 1, 1);
            Name = "ClientesMorosos_Form";
            Text = "ClientesMorosos_Form";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientesVencidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox Btn_Atras;
        private PictureBox btn_minimizar;
        private PictureBox btn_cerrar;
        private DataGridView dgvClientesVencidos;
    }
}