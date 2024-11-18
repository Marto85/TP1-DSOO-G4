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
            Txt_DNI = new TextBox();
            DNI = new Label();
            Txt_EsSocio = new TextBox();
            Txt_Apellido = new TextBox();
            Txt_Nombre = new TextBox();
            EsSocio = new Label();
            Apellido = new Label();
            Nombre = new Label();
            label2 = new Label();
            Frecuencia_Pago = new ComboBox();
            label_AbonoMensual = new Label();
            txt_AbonoMensual = new TextBox();
            label_Pagar_Actividades = new Label();
            lista_actividades = new CheckedListBox();
            Btn_Pagar = new Button();
            label5 = new Label();
            total_pago = new TextBox();
            Btn_Calcular_Total = new Button();
            label_FormaDePago = new Label();
            formas_de_pago = new CheckedListBox();
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
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 22);
            panel2.TabIndex = 12;
            panel2.MouseDown += Panel2_MouseDown;
            // 
            // Btn_Atras
            // 
            Btn_Atras.Cursor = Cursors.Hand;
            Btn_Atras.Image = (Image)resources.GetObject("Btn_Atras.Image");
            Btn_Atras.Location = new Point(1, 1);
            Btn_Atras.Margin = new Padding(1);
            Btn_Atras.Name = "Btn_Atras";
            Btn_Atras.Size = new Size(32, 20);
            Btn_Atras.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Atras.TabIndex = 13;
            Btn_Atras.TabStop = false;
            Btn_Atras.Click += Btn_Atras_Click;
            // 
            // Btn_minimizar
            // 
            Btn_minimizar.Cursor = Cursors.Hand;
            Btn_minimizar.Image = (Image)resources.GetObject("Btn_minimizar.Image");
            Btn_minimizar.Location = new Point(677, 1);
            Btn_minimizar.Margin = new Padding(1);
            Btn_minimizar.Name = "Btn_minimizar";
            Btn_minimizar.Size = new Size(32, 20);
            Btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_minimizar.TabIndex = 8;
            Btn_minimizar.TabStop = false;
            Btn_minimizar.Click += Btn_minimizar_Click;
            // 
            // Btn_cerrar
            // 
            Btn_cerrar.Cursor = Cursors.Hand;
            Btn_cerrar.Image = (Image)resources.GetObject("Btn_cerrar.Image");
            Btn_cerrar.Location = new Point(710, 1);
            Btn_cerrar.Margin = new Padding(1);
            Btn_cerrar.Name = "Btn_cerrar";
            Btn_cerrar.Size = new Size(32, 20);
            Btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_cerrar.TabIndex = 7;
            Btn_cerrar.TabStop = false;
            Btn_cerrar.Click += Btn_cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(457, 34);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 13;
            label1.Text = "Registro de Pagos";
            // 
            // Buscar_Cliente
            // 
            Buscar_Cliente.BackColor = SystemColors.Highlight;
            Buscar_Cliente.Cursor = Cursors.Hand;
            Buscar_Cliente.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Buscar_Cliente.Location = new Point(78, 71);
            Buscar_Cliente.Name = "Buscar_Cliente";
            Buscar_Cliente.Size = new Size(160, 25);
            Buscar_Cliente.TabIndex = 17;
            Buscar_Cliente.Text = "Buscar";
            Buscar_Cliente.UseVisualStyleBackColor = false;
            Buscar_Cliente.Click += Buscar_Cliente_Click;
            // 
            // DNI_Pagos
            // 
            DNI_Pagos.BackColor = Color.FromArgb(15, 15, 15);
            DNI_Pagos.Cursor = Cursors.Hand;
            DNI_Pagos.Font = new Font("Century Gothic", 11.1F, FontStyle.Italic, GraphicsUnit.Point);
            DNI_Pagos.ForeColor = Color.Gray;
            DNI_Pagos.Location = new Point(77, 35);
            DNI_Pagos.Name = "DNI_Pagos";
            DNI_Pagos.Size = new Size(163, 26);
            DNI_Pagos.TabIndex = 16;
            DNI_Pagos.Text = "DNI de cliente";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Txt_DNI);
            panel1.Controls.Add(DNI);
            panel1.Controls.Add(Txt_EsSocio);
            panel1.Controls.Add(Txt_Apellido);
            panel1.Controls.Add(Txt_Nombre);
            panel1.Controls.Add(EsSocio);
            panel1.Controls.Add(Apellido);
            panel1.Controls.Add(Nombre);
            panel1.Location = new Point(28, 119);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 152);
            panel1.TabIndex = 18;
            // 
            // Txt_DNI
            // 
            Txt_DNI.BackColor = SystemColors.Highlight;
            Txt_DNI.BorderStyle = BorderStyle.None;
            Txt_DNI.Font = new Font("Century Gothic", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_DNI.Location = new Point(126, 16);
            Txt_DNI.Margin = new Padding(1);
            Txt_DNI.Name = "Txt_DNI";
            Txt_DNI.Size = new Size(103, 17);
            Txt_DNI.TabIndex = 29;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            DNI.Location = new Point(21, 15);
            DNI.Margin = new Padding(1, 0, 1, 0);
            DNI.Name = "DNI";
            DNI.Size = new Size(38, 18);
            DNI.TabIndex = 29;
            DNI.Text = "DNI:";
            // 
            // Txt_EsSocio
            // 
            Txt_EsSocio.BackColor = SystemColors.Highlight;
            Txt_EsSocio.BorderStyle = BorderStyle.None;
            Txt_EsSocio.Location = new Point(126, 121);
            Txt_EsSocio.Margin = new Padding(1);
            Txt_EsSocio.Name = "Txt_EsSocio";
            Txt_EsSocio.Size = new Size(103, 16);
            Txt_EsSocio.TabIndex = 5;
            // 
            // Txt_Apellido
            // 
            Txt_Apellido.BackColor = SystemColors.Highlight;
            Txt_Apellido.BorderStyle = BorderStyle.None;
            Txt_Apellido.Location = new Point(126, 84);
            Txt_Apellido.Margin = new Padding(1);
            Txt_Apellido.Name = "Txt_Apellido";
            Txt_Apellido.Size = new Size(103, 16);
            Txt_Apellido.TabIndex = 4;
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.BackColor = SystemColors.Highlight;
            Txt_Nombre.BorderStyle = BorderStyle.None;
            Txt_Nombre.Font = new Font("Century Gothic", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Nombre.Location = new Point(126, 48);
            Txt_Nombre.Margin = new Padding(1);
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.Size = new Size(103, 17);
            Txt_Nombre.TabIndex = 3;
            // 
            // EsSocio
            // 
            EsSocio.AutoSize = true;
            EsSocio.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            EsSocio.Location = new Point(21, 120);
            EsSocio.Margin = new Padding(1, 0, 1, 0);
            EsSocio.Name = "EsSocio";
            EsSocio.Size = new Size(72, 18);
            EsSocio.TabIndex = 2;
            EsSocio.Text = "Es Socio:";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Apellido.Location = new Point(21, 82);
            Apellido.Margin = new Padding(1, 0, 1, 0);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(75, 18);
            Apellido.TabIndex = 1;
            Apellido.Text = "Apellido:";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre.Location = new Point(21, 46);
            Nombre.Margin = new Padding(1, 0, 1, 0);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(72, 18);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(471, 121);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 19;
            label2.Text = "Frecuencia";
            // 
            // Frecuencia_Pago
            // 
            Frecuencia_Pago.Cursor = Cursors.Hand;
            Frecuencia_Pago.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            Frecuencia_Pago.FormattingEnabled = true;
            Frecuencia_Pago.Items.AddRange(new object[] { "Semanal", "Quincenal", "Mensual", "Trimestral", "Semestral", "Anual" });
            Frecuencia_Pago.Location = new Point(596, 119);
            Frecuencia_Pago.Margin = new Padding(1);
            Frecuencia_Pago.Name = "Frecuencia_Pago";
            Frecuencia_Pago.Size = new Size(127, 28);
            Frecuencia_Pago.TabIndex = 20;
            // 
            // label_AbonoMensual
            // 
            label_AbonoMensual.AutoSize = true;
            label_AbonoMensual.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label_AbonoMensual.Location = new Point(347, 89);
            label_AbonoMensual.Margin = new Padding(1, 0, 1, 0);
            label_AbonoMensual.Name = "label_AbonoMensual";
            label_AbonoMensual.Size = new Size(213, 18);
            label_AbonoMensual.TabIndex = 21;
            label_AbonoMensual.Text = "Abono Mensual para socios";
            // 
            // txt_AbonoMensual
            // 
            txt_AbonoMensual.Font = new Font("Segoe UI", 11.1F, FontStyle.Regular, GraphicsUnit.Point);
            txt_AbonoMensual.Location = new Point(596, 89);
            txt_AbonoMensual.Margin = new Padding(1);
            txt_AbonoMensual.Name = "txt_AbonoMensual";
            txt_AbonoMensual.Size = new Size(127, 27);
            txt_AbonoMensual.TabIndex = 22;
            // 
            // label_Pagar_Actividades
            // 
            label_Pagar_Actividades.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label_Pagar_Actividades.Location = new Point(612, 198);
            label_Pagar_Actividades.Margin = new Padding(1, 0, 1, 0);
            label_Pagar_Actividades.Name = "label_Pagar_Actividades";
            label_Pagar_Actividades.Size = new Size(103, 41);
            label_Pagar_Actividades.TabIndex = 23;
            label_Pagar_Actividades.Text = "Seleccionar actividades";
            label_Pagar_Actividades.Visible = false;
            // 
            // lista_actividades
            // 
            lista_actividades.Cursor = Cursors.Hand;
            lista_actividades.FormattingEnabled = true;
            lista_actividades.Items.AddRange(new object[] { "Yoga", "Pilates", "Zumba", "Crossfit", "Natacion", "Futbol" });
            lista_actividades.Location = new Point(597, 244);
            lista_actividades.Margin = new Padding(1);
            lista_actividades.Name = "lista_actividades";
            lista_actividades.Size = new Size(126, 94);
            lista_actividades.TabIndex = 24;
            lista_actividades.Visible = false;
            // 
            // Btn_Pagar
            // 
            Btn_Pagar.BackColor = SystemColors.Highlight;
            Btn_Pagar.Cursor = Cursors.Hand;
            Btn_Pagar.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Pagar.Location = new Point(348, 349);
            Btn_Pagar.Margin = new Padding(1);
            Btn_Pagar.Name = "Btn_Pagar";
            Btn_Pagar.Size = new Size(375, 30);
            Btn_Pagar.TabIndex = 25;
            Btn_Pagar.Text = "Pagar";
            Btn_Pagar.UseVisualStyleBackColor = false;
            Btn_Pagar.Click += Btn_Pagar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(348, 260);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 18);
            label5.TabIndex = 26;
            label5.Text = "Total a Pagar: $";
            // 
            // total_pago
            // 
            total_pago.BackColor = Color.DimGray;
            total_pago.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            total_pago.Location = new Point(471, 256);
            total_pago.Margin = new Padding(1);
            total_pago.Name = "total_pago";
            total_pago.Size = new Size(110, 27);
            total_pago.TabIndex = 27;
            // 
            // Btn_Calcular_Total
            // 
            Btn_Calcular_Total.BackColor = SystemColors.Highlight;
            Btn_Calcular_Total.Cursor = Cursors.Hand;
            Btn_Calcular_Total.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Calcular_Total.Location = new Point(471, 284);
            Btn_Calcular_Total.Margin = new Padding(1);
            Btn_Calcular_Total.Name = "Btn_Calcular_Total";
            Btn_Calcular_Total.Size = new Size(110, 38);
            Btn_Calcular_Total.TabIndex = 28;
            Btn_Calcular_Total.Text = "Calcular";
            Btn_Calcular_Total.UseVisualStyleBackColor = false;
            Btn_Calcular_Total.Click += Btn_Calcular_Total_Click;
            // 
            // label_FormaDePago
            // 
            label_FormaDePago.AutoSize = true;
            label_FormaDePago.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            label_FormaDePago.Location = new Point(347, 161);
            label_FormaDePago.Margin = new Padding(1, 0, 1, 0);
            label_FormaDePago.Name = "label_FormaDePago";
            label_FormaDePago.Size = new Size(120, 18);
            label_FormaDePago.TabIndex = 29;
            label_FormaDePago.Text = "Forma de Pago";
            label_FormaDePago.Visible = false;
            // 
            // formas_de_pago
            // 
            formas_de_pago.FormattingEnabled = true;
            formas_de_pago.Items.AddRange(new object[] { "Tarjeta de Credito", "Efectivo" });
            formas_de_pago.Location = new Point(471, 161);
            formas_de_pago.Margin = new Padding(1);
            formas_de_pago.Name = "formas_de_pago";
            formas_de_pago.Size = new Size(131, 40);
            formas_de_pago.TabIndex = 30;
            formas_de_pago.ItemCheck += Formas_de_pago_ItemCheck;
            // 
            // Pago_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(744, 398);
            Controls.Add(formas_de_pago);
            Controls.Add(label_FormaDePago);
            Controls.Add(Btn_Calcular_Total);
            Controls.Add(total_pago);
            Controls.Add(label5);
            Controls.Add(Btn_Pagar);
            Controls.Add(lista_actividades);
            Controls.Add(label_Pagar_Actividades);
            Controls.Add(txt_AbonoMensual);
            Controls.Add(label_AbonoMensual);
            Controls.Add(Frecuencia_Pago);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(Buscar_Cliente);
            Controls.Add(DNI_Pagos);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "Pago_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago_Form";
            MouseDown += Pago_Form_MouseDown;
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
        private Label EsSocio;
        private Label Apellido;
        private Label label2;
        private ComboBox Frecuencia_Pago;
        private Label label_AbonoMensual;
        private TextBox txt_AbonoMensual;
        private Label label_Pagar_Actividades;
        private CheckedListBox lista_actividades;
        private Button Btn_Pagar;
        private Label label5;
        private TextBox total_pago;
        private TextBox Txt_Nombre;
        private TextBox Txt_EsSocio;
        private TextBox Txt_Apellido;
        private Button Btn_Calcular_Total;
        private TextBox Txt_DNI;
        private Label DNI;
        private Label label_FormaDePago;
        private CheckedListBox formas_de_pago;
    }
}