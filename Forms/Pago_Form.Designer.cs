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
            panel1 = new Panel();
            Actividades = new Label();
            EsSocio = new Label();
            Apellido = new Label();
            Nombre = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_cerrar).BeginInit();
            panel1.SuspendLayout();
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
            label1.Location = new Point(1111, 92);
            label1.Name = "label1";
            label1.Size = new Size(429, 56);
            label1.TabIndex = 13;
            label1.Text = "Registro de Pagos";
            // 
            // Buscar_Cliente
            // 
            Buscar_Cliente.BackColor = SystemColors.Highlight;
            Buscar_Cliente.Cursor = Cursors.Hand;
            Buscar_Cliente.FlatStyle = FlatStyle.Flat;
            Buscar_Cliente.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Buscar_Cliente.Location = new Point(189, 165);
            Buscar_Cliente.Margin = new Padding(7, 8, 7, 8);
            Buscar_Cliente.Name = "Buscar_Cliente";
            Buscar_Cliente.Size = new Size(388, 67);
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
            DNI_Pagos.Location = new Point(188, 95);
            DNI_Pagos.Margin = new Padding(7, 8, 7, 8);
            DNI_Pagos.Name = "DNI_Pagos";
            DNI_Pagos.Size = new Size(389, 53);
            DNI_Pagos.TabIndex = 16;
            DNI_Pagos.Text = "DNI de cliente";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Actividades);
            panel1.Controls.Add(EsSocio);
            panel1.Controls.Add(Apellido);
            panel1.Controls.Add(Nombre);
            panel1.Location = new Point(51, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 622);
            panel1.TabIndex = 18;
            // 
            // Actividades
            // 
            Actividades.AutoSize = true;
            Actividades.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Actividades.Location = new Point(52, 374);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(242, 44);
            Actividades.TabIndex = 3;
            Actividades.Text = "Actividades:";
            // 
            // EsSocio
            // 
            EsSocio.AutoSize = true;
            EsSocio.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            EsSocio.Location = new Point(52, 281);
            EsSocio.Name = "EsSocio";
            EsSocio.Size = new Size(174, 44);
            EsSocio.TabIndex = 2;
            EsSocio.Text = "Es Socio:";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Apellido.Location = new Point(52, 185);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(179, 44);
            Apellido.TabIndex = 1;
            Apellido.Text = "Apellido:";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre.Location = new Point(52, 80);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(175, 44);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(871, 332);
            label2.Name = "label2";
            label2.Size = new Size(222, 44);
            label2.TabIndex = 19;
            label2.Text = "Frecuencia";
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Semanal", "Quincenal", "Mensual", "Trimestral", "Semestral", "Anual" });
            comboBox1.Location = new Point(1447, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 58);
            comboBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(871, 243);
            label3.Name = "label3";
            label3.Size = new Size(517, 44);
            label3.TabIndex = 21;
            label3.Text = "Abono Mensual para socios";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(1447, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 57);
            textBox1.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(871, 430);
            label4.Name = "label4";
            label4.Size = new Size(347, 44);
            label4.TabIndex = 23;
            label4.Text = "Pagar Actividades";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Cursor = Cursors.Hand;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Yoga", "Pilates", "Zumba", "Crossfit", "Natacion", "Escuela de Futbol" });
            checkedListBox1.Location = new Point(1449, 430);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(300, 268);
            checkedListBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(871, 782);
            button1.Name = "button1";
            button1.Size = new Size(878, 83);
            button1.TabIndex = 25;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(871, 552);
            label5.Name = "label5";
            label5.Size = new Size(262, 44);
            label5.TabIndex = 26;
            label5.Text = "Total a Pagar:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Highlight;
            textBox2.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(883, 599);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 57);
            textBox2.TabIndex = 27;
            // 
            // Pago_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1806, 901);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label Nombre;
        private Label Actividades;
        private Label EsSocio;
        private Label Apellido;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Label label5;
        private TextBox textBox2;
    }
}