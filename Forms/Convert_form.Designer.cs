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
            button1 = new Button();
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
            btn_minimizar.Location = new Point(653, 0);
            btn_minimizar.Margin = new Padding(1);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(28, 17);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(684, 0);
            btn_cerrar.Margin = new Padding(1);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(28, 17);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(btn_minimizar);
            panel2.Controls.Add(btn_cerrar);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 20);
            panel2.TabIndex = 12;
            // 
            // ID_Registro
            // 
            ID_Registro.BackColor = Color.FromArgb(15, 15, 15);
            ID_Registro.Cursor = Cursors.Hand;
            ID_Registro.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            ID_Registro.ForeColor = Color.Gray;
            ID_Registro.Location = new Point(207, 90);
            ID_Registro.Name = "ID_Registro";
            ID_Registro.Size = new Size(159, 26);
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
            convertLabel.Location = new Point(277, 56);
            convertLabel.Margin = new Padding(1, 0, 1, 0);
            convertLabel.Name = "convertLabel";
            convertLabel.Size = new Size(143, 18);
            convertLabel.TabIndex = 14;
            convertLabel.Text = "Convertir Cliente";
            convertLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(387, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 143);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 16;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convert_button
            // 
            convert_button.Location = new Point(304, 196);
            convert_button.Name = "convert_button";
            convert_button.Size = new Size(75, 23);
            convert_button.TabIndex = 17;
            convert_button.Text = "Convertir";
            convert_button.UseVisualStyleBackColor = true;
            convert_button.Visible = false;
            convert_button.Click += Convert_button_Click;
            // 
            // Convert_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(712, 289);
            Controls.Add(convert_button);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(convertLabel);
            Controls.Add(ID_Registro);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Convert_form";
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
        private Button button1;
        private Label label1;
        private Button convert_button;
    }
}