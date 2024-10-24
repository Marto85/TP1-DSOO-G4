namespace DSOO_Grupo4_TP1.Forms
{
    partial class Inscribir_Actividad_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscribir_Actividad_Form));
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            panel2 = new Panel();
            Btn_Atras = new PictureBox();
            convertLabel = new Label();
            ID_Registro = new TextBox();
            Buscar_Cliente_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            checkBoxYoga = new CheckBox();
            checkBoxPilates = new CheckBox();
            checkBoxZumba = new CheckBox();
            checkBoxCrossfit = new CheckBox();
            checkBoxNatacion = new CheckBox();
            checkBoxFutbol = new CheckBox();
            Inscripcion_Actividades_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).BeginInit();
            SuspendLayout();
            // 
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1579, 0);
            btn_minimizar.Margin = new Padding(2, 3, 2, 3);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(78, 55);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(1659, -3);
            btn_cerrar.Margin = new Padding(2, 3, 2, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(78, 55);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
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
            panel2.Size = new Size(1729, 55);
            panel2.TabIndex = 13;
            panel2.MouseDown += panel2_MouseDown;
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
            Btn_Atras.TabIndex = 27;
            Btn_Atras.TabStop = false;
            Btn_Atras.Click += Btn_Atras_Click;
            // 
            // convertLabel
            // 
            convertLabel.AutoSize = true;
            convertLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            convertLabel.ForeColor = SystemColors.ActiveCaptionText;
            convertLabel.Location = new Point(699, 145);
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
            ID_Registro.Location = new Point(668, 251);
            ID_Registro.Margin = new Padding(7, 8, 7, 8);
            ID_Registro.Name = "ID_Registro";
            ID_Registro.Size = new Size(380, 53);
            ID_Registro.TabIndex = 16;
            ID_Registro.Text = "ID de cliente";
            ID_Registro.Enter += ID_Registro_Enter;
            ID_Registro.Leave += ID_Registro_Leave;
            // 
            // Buscar_Cliente_Button
            // 
            Buscar_Cliente_Button.BackColor = SystemColors.Highlight;
            Buscar_Cliente_Button.Cursor = Cursors.Hand;
            Buscar_Cliente_Button.FlatStyle = FlatStyle.Flat;
            Buscar_Cliente_Button.Location = new Point(1127, 249);
            Buscar_Cliente_Button.Margin = new Padding(7, 8, 7, 8);
            Buscar_Cliente_Button.Name = "Buscar_Cliente_Button";
            Buscar_Cliente_Button.Size = new Size(182, 63);
            Buscar_Cliente_Button.TabIndex = 17;
            Buscar_Cliente_Button.Text = "Buscar";
            Buscar_Cliente_Button.UseVisualStyleBackColor = false;
            Buscar_Cliente_Button.Click += BuscarClienteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 350);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 18;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(364, 443);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(999, 50);
            label2.TabIndex = 19;
            label2.Text = "Seleccionar en que actividad/es desea inscribirse";
            // 
            // checkBoxYoga
            // 
            checkBoxYoga.AutoSize = true;
            checkBoxYoga.Cursor = Cursors.Hand;
            checkBoxYoga.Font = new Font("Century Gothic", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxYoga.Location = new Point(403, 574);
            checkBoxYoga.Margin = new Padding(2, 3, 2, 3);
            checkBoxYoga.Name = "checkBoxYoga";
            checkBoxYoga.Size = new Size(142, 44);
            checkBoxYoga.TabIndex = 20;
            checkBoxYoga.Text = "Yoga";
            checkBoxYoga.UseVisualStyleBackColor = true;
            // 
            // checkBoxPilates
            // 
            checkBoxPilates.AutoSize = true;
            checkBoxPilates.Cursor = Cursors.Hand;
            checkBoxPilates.Font = new Font("Century Gothic", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxPilates.Location = new Point(403, 651);
            checkBoxPilates.Margin = new Padding(2, 3, 2, 3);
            checkBoxPilates.Name = "checkBoxPilates";
            checkBoxPilates.Size = new Size(159, 44);
            checkBoxPilates.TabIndex = 21;
            checkBoxPilates.Text = "Pilates";
            checkBoxPilates.UseVisualStyleBackColor = true;
            // 
            // checkBoxZumba
            // 
            checkBoxZumba.AutoSize = true;
            checkBoxZumba.Cursor = Cursors.Hand;
            checkBoxZumba.Font = new Font("Century Gothic", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxZumba.Location = new Point(709, 574);
            checkBoxZumba.Margin = new Padding(2, 3, 2, 3);
            checkBoxZumba.Name = "checkBoxZumba";
            checkBoxZumba.Size = new Size(168, 44);
            checkBoxZumba.TabIndex = 22;
            checkBoxZumba.Text = "Zumba";
            checkBoxZumba.UseVisualStyleBackColor = true;
            // 
            // checkBoxCrossfit
            // 
            checkBoxCrossfit.AutoSize = true;
            checkBoxCrossfit.Cursor = Cursors.Hand;
            checkBoxCrossfit.Font = new Font("Century Gothic", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxCrossfit.Location = new Point(709, 651);
            checkBoxCrossfit.Margin = new Padding(2, 3, 2, 3);
            checkBoxCrossfit.Name = "checkBoxCrossfit";
            checkBoxCrossfit.Size = new Size(173, 44);
            checkBoxCrossfit.TabIndex = 23;
            checkBoxCrossfit.Text = "Crossfit";
            checkBoxCrossfit.UseVisualStyleBackColor = true;
            // 
            // checkBoxNatacion
            // 
            checkBoxNatacion.AutoSize = true;
            checkBoxNatacion.Cursor = Cursors.Hand;
            checkBoxNatacion.Font = new Font("Century Gothic", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxNatacion.Location = new Point(1018, 574);
            checkBoxNatacion.Margin = new Padding(2, 3, 2, 3);
            checkBoxNatacion.Name = "checkBoxNatacion";
            checkBoxNatacion.Size = new Size(206, 44);
            checkBoxNatacion.TabIndex = 24;
            checkBoxNatacion.Text = "Natacion";
            checkBoxNatacion.UseVisualStyleBackColor = true;
            // 
            // checkBoxFutbol
            // 
            checkBoxFutbol.AutoSize = true;
            checkBoxFutbol.Cursor = Cursors.Hand;
            checkBoxFutbol.Font = new Font("Century Gothic", 9.900001F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxFutbol.Location = new Point(1018, 651);
            checkBoxFutbol.Margin = new Padding(2, 3, 2, 3);
            checkBoxFutbol.Name = "checkBoxFutbol";
            checkBoxFutbol.Size = new Size(153, 44);
            checkBoxFutbol.TabIndex = 25;
            checkBoxFutbol.Text = "Futbol";
            checkBoxFutbol.UseVisualStyleBackColor = true;
            // 
            // Inscripcion_Actividades_Button
            // 
            Inscripcion_Actividades_Button.BackColor = SystemColors.Highlight;
            Inscripcion_Actividades_Button.Cursor = Cursors.Hand;
            Inscripcion_Actividades_Button.FlatStyle = FlatStyle.Flat;
            Inscripcion_Actividades_Button.Location = new Point(614, 752);
            Inscripcion_Actividades_Button.Margin = new Padding(7, 8, 7, 8);
            Inscripcion_Actividades_Button.Name = "Inscripcion_Actividades_Button";
            Inscripcion_Actividades_Button.Size = new Size(376, 82);
            Inscripcion_Actividades_Button.TabIndex = 26;
            Inscripcion_Actividades_Button.Text = "Realizar la inscripcion";
            Inscripcion_Actividades_Button.UseVisualStyleBackColor = false;
            Inscripcion_Actividades_Button.Click += Inscripcion_Actividades_Button_Click;
            // 
            // Inscribir_Actividad_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1734, 880);
            Controls.Add(Inscripcion_Actividades_Button);
            Controls.Add(checkBoxFutbol);
            Controls.Add(checkBoxNatacion);
            Controls.Add(checkBoxCrossfit);
            Controls.Add(checkBoxZumba);
            Controls.Add(checkBoxPilates);
            Controls.Add(checkBoxYoga);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Buscar_Cliente_Button);
            Controls.Add(ID_Registro);
            Controls.Add(convertLabel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Inscribir_Actividad_Form";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busca_Cliente_Form";
            MouseDown += Inscribir_Actividad_Form_MouseDown;
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btn_minimizar;
        private PictureBox btn_cerrar;
        private Panel panel2;
        private Label convertLabel;
        private TextBox ID_Registro;
        private Button Buscar_Cliente_Button;
        private Label label1;
        private Label label2;
        private CheckBox checkBoxYoga;
        private CheckBox checkBoxPilates;
        private CheckBox checkBoxZumba;
        private CheckBox checkBoxCrossfit;
        private CheckBox checkBoxNatacion;
        private CheckBox checkBoxFutbol;
        private Button Inscripcion_Actividades_Button;
        private PictureBox Btn_Atras;
    }
}