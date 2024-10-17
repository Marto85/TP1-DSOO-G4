namespace DSOO_Grupo4_TP1
{
    partial class Convert_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convert_form));
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            panel2 = new Panel();
            ID_Registro = new TextBox();
            convertLabel = new Label();
            Buscar_Cliente = new Button();
            label1 = new Label();
            convert_button = new Button();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btn_minimizar);
            panel2.Controls.Add(btn_cerrar);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1729, 55);
            panel2.TabIndex = 12;
            // 
            // ID_Registro
            // 
            ID_Registro.BackColor = Color.FromArgb(15, 15, 15);
            ID_Registro.Cursor = Cursors.Hand;
            ID_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            ID_Registro.ForeColor = Color.Gray;
            ID_Registro.Location = new Point(503, 246);
            ID_Registro.Margin = new Padding(7, 8, 7, 8);
            ID_Registro.Name = "ID_Registro";
            ID_Registro.Size = new Size(380, 53);
            ID_Registro.TabIndex = 13;
            ID_Registro.Text = "ID de cliente";
            ID_Registro.TextChanged += ID_Registro_TextChanged;
            ID_Registro.Enter += ID_Registro_Enter;
            ID_Registro.Leave += ID_Registro_Leave;
            // 
            // convertLabel
            // 
            convertLabel.AutoSize = true;
            convertLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            convertLabel.ForeColor = SystemColors.ActiveCaptionText;
            convertLabel.Location = new Point(673, 153);
            convertLabel.Margin = new Padding(2, 0, 2, 0);
            convertLabel.Name = "convertLabel";
            convertLabel.Size = new Size(353, 46);
            convertLabel.TabIndex = 14;
            convertLabel.Text = "Convertir Cliente";
            convertLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Buscar_Cliente
            // 
            Buscar_Cliente.Location = new Point(940, 251);
            Buscar_Cliente.Margin = new Padding(7, 8, 7, 8);
            Buscar_Cliente.Name = "Buscar_Cliente";
            Buscar_Cliente.Size = new Size(182, 63);
            Buscar_Cliente.TabIndex = 15;
            Buscar_Cliente.Text = "Buscar";
            Buscar_Cliente.UseVisualStyleBackColor = true;
            Buscar_Cliente.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 391);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 16;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convert_button
            // 
            convert_button.Location = new Point(738, 536);
            convert_button.Margin = new Padding(7, 8, 7, 8);
            convert_button.Name = "convert_button";
            convert_button.Size = new Size(182, 63);
            convert_button.TabIndex = 17;
            convert_button.Text = "Convertir";
            convert_button.UseVisualStyleBackColor = true;
            convert_button.Visible = false;
            convert_button.Click += Convert_button_Click;
            // 
            // Convert_form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1729, 790);
            Controls.Add(convert_button);
            Controls.Add(label1);
            Controls.Add(Buscar_Cliente);
            Controls.Add(convertLabel);
            Controls.Add(ID_Registro);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "Convert_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_minimizar;
        private PictureBox btn_cerrar;
        private Panel panel2;
        private TextBox ID_Registro;
        private Label convertLabel;
        private Button Buscar_Cliente;
        private Label label1;
        private Button convert_button;
    }
}