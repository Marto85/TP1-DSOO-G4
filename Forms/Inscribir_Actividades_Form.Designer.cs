namespace DSOO_Grupo4_TP1.Forms
{
    partial class Inscribir_Actividades_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscribir_Actividades_Form));
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            panel2 = new Panel();
            convertLabel = new Label();
            ID_Registro = new TextBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1597, 3);
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
            btn_cerrar.Location = new Point(1659, 3);
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
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1729, 55);
            panel2.TabIndex = 13;
            // 
            // convertLabel
            // 
            convertLabel.AutoSize = true;
            convertLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            convertLabel.ForeColor = SystemColors.ActiveCaptionText;
            convertLabel.Location = new Point(699, 146);
            convertLabel.Margin = new Padding(2, 0, 2, 0);
            convertLabel.Name = "convertLabel";
            convertLabel.Size = new Size(309, 46);
            convertLabel.TabIndex = 15;
            convertLabel.Text = "Buscar Cliente";
            convertLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ID_Registro
            // 
            ID_Registro.BackColor = Color.FromArgb(15, 15, 15);
            ID_Registro.Cursor = Cursors.Hand;
            ID_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            ID_Registro.ForeColor = Color.Gray;
            ID_Registro.Location = new Point(667, 252);
            ID_Registro.Margin = new Padding(7, 8, 7, 8);
            ID_Registro.Name = "ID_Registro";
            ID_Registro.Size = new Size(380, 53);
            ID_Registro.TabIndex = 16;
            ID_Registro.Text = "ID de cliente";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(1126, 248);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(182, 63);
            button1.TabIndex = 17;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(868, 335);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 18;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inscribir_Actividades_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1727, 700);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(ID_Registro);
            Controls.Add(convertLabel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inscribir_Actividades_Form";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca_Cliente_Form";
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
        private Label convertLabel;
        private TextBox ID_Registro;
        private Button button1;
        private Label label1;
    }
}