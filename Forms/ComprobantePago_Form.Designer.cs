namespace DSOO_Grupo4_TP1.Forms
{
    partial class ComprobantePago_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprobantePago_Form));
            lblMonto = new Label();
            lblFechaPago = new Label();
            lblProximoVencimiento = new Label();
            lblTipoPago = new Label();
            lbl_formaPago = new Label();
            pictureBox1 = new PictureBox();
            FctOriginal = new TextBox();
            RazonSocial = new TextBox();
            TipoFct = new TextBox();
            splitContainer1 = new SplitContainer();
            CondIVAClub = new TextBox();
            lbl_CondIVA = new Label();
            DomComercial = new TextBox();
            lbl_DomComercial = new Label();
            NombreFantasia = new TextBox();
            lbl_RazonSocial = new Label();
            txt_fechaComprobante = new TextBox();
            CUIT = new TextBox();
            FechaInicioAct = new TextBox();
            IIBB = new TextBox();
            txt_NroComp = new TextBox();
            lbl_NroComp = new Label();
            PtoVenta = new TextBox();
            lbl_FechaInicioAct = new Label();
            lbl_IIBB = new Label();
            lbl_CUIT = new Label();
            lbl_PuntoVenta = new Label();
            panel1 = new Panel();
            txt_formaPago = new TextBox();
            txt_proximoVencimiento = new TextBox();
            txt_frecuenciaPago = new TextBox();
            txt_dni = new TextBox();
            txt_nombreCliente = new TextBox();
            lbl_NombreCliente = new Label();
            CondIVACliente = new TextBox();
            label1 = new Label();
            lbl_DNICliente = new Label();
            dgvActividades = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Clase = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Bonificacion = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            lbl_CodAct = new TextBox();
            textBox1 = new TextBox();
            Lbl_Bonificacion = new TextBox();
            lbl_PrecioUnit = new TextBox();
            lbl_Subtotal = new TextBox();
            Btn_ImprimirComprobante = new Button();
            Btn_cerrar = new PictureBox();
            Btn_minimizar = new PictureBox();
            panel2 = new Panel();
            textBox_total = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_minimizar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(51, 259);
            lblMonto.Margin = new Padding(1, 0, 1, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaPago.Location = new Point(31, 41);
            lblFechaPago.Margin = new Padding(1, 0, 1, 0);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(104, 15);
            lblFechaPago.TabIndex = 1;
            lblFechaPago.Text = "Fecha de Emision:";
            // 
            // lblProximoVencimiento
            // 
            lblProximoVencimiento.AutoSize = true;
            lblProximoVencimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProximoVencimiento.Location = new Point(313, 61);
            lblProximoVencimiento.Margin = new Padding(1, 0, 1, 0);
            lblProximoVencimiento.Name = "lblProximoVencimiento";
            lblProximoVencimiento.Size = new Size(130, 15);
            lblProximoVencimiento.TabIndex = 2;
            lblProximoVencimiento.Text = "Proximo Vencimiento:";
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoPago.Location = new Point(5, 63);
            lblTipoPago.Margin = new Padding(1, 0, 1, 0);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(117, 15);
            lblTipoPago.TabIndex = 3;
            lblTipoPago.Text = "Frecuencia de Pago:";
            // 
            // lbl_formaPago
            // 
            lbl_formaPago.AutoSize = true;
            lbl_formaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_formaPago.Location = new Point(5, 33);
            lbl_formaPago.Margin = new Padding(1, 0, 1, 0);
            lbl_formaPago.Name = "lbl_formaPago";
            lbl_formaPago.Size = new Size(111, 15);
            lbl_formaPago.TabIndex = 5;
            lbl_formaPago.Text = "Condicion de Pago:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sports_club_logo;
            pictureBox1.Location = new Point(7, 4);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FctOriginal
            // 
            FctOriginal.BackColor = SystemColors.Control;
            FctOriginal.BorderStyle = BorderStyle.FixedSingle;
            FctOriginal.Font = new Font("Century Gothic", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            FctOriginal.Location = new Point(28, 30);
            FctOriginal.Margin = new Padding(1);
            FctOriginal.Name = "FctOriginal";
            FctOriginal.Size = new Size(581, 40);
            FctOriginal.TabIndex = 7;
            FctOriginal.Text = "ORIGINAL";
            FctOriginal.TextAlign = HorizontalAlignment.Center;
            // 
            // RazonSocial
            // 
            RazonSocial.BackColor = SystemColors.Control;
            RazonSocial.BorderStyle = BorderStyle.None;
            RazonSocial.Font = new Font("Century Gothic", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            RazonSocial.Location = new Point(87, 71);
            RazonSocial.Margin = new Padding(1);
            RazonSocial.Name = "RazonSocial";
            RazonSocial.Size = new Size(141, 17);
            RazonSocial.TabIndex = 8;
            RazonSocial.Text = "ArgySports S.R.L.";
            // 
            // TipoFct
            // 
            TipoFct.BackColor = SystemColors.Control;
            TipoFct.BorderStyle = BorderStyle.FixedSingle;
            TipoFct.Font = new Font("Century Gothic", 21.9F, FontStyle.Bold, GraphicsUnit.Point);
            TipoFct.Location = new Point(285, 61);
            TipoFct.Margin = new Padding(1);
            TipoFct.Name = "TipoFct";
            TipoFct.Size = new Size(51, 43);
            TipoFct.TabIndex = 9;
            TipoFct.Text = "X";
            TipoFct.TextAlign = HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(28, 61);
            splitContainer1.Margin = new Padding(1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CondIVAClub);
            splitContainer1.Panel1.Controls.Add(lbl_CondIVA);
            splitContainer1.Panel1.Controls.Add(DomComercial);
            splitContainer1.Panel1.Controls.Add(lbl_DomComercial);
            splitContainer1.Panel1.Controls.Add(NombreFantasia);
            splitContainer1.Panel1.Controls.Add(lbl_RazonSocial);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(RazonSocial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txt_fechaComprobante);
            splitContainer1.Panel2.Controls.Add(CUIT);
            splitContainer1.Panel2.Controls.Add(FechaInicioAct);
            splitContainer1.Panel2.Controls.Add(IIBB);
            splitContainer1.Panel2.Controls.Add(txt_NroComp);
            splitContainer1.Panel2.Controls.Add(lbl_NroComp);
            splitContainer1.Panel2.Controls.Add(PtoVenta);
            splitContainer1.Panel2.Controls.Add(lbl_FechaInicioAct);
            splitContainer1.Panel2.Controls.Add(lblFechaPago);
            splitContainer1.Panel2.Controls.Add(lbl_IIBB);
            splitContainer1.Panel2.Controls.Add(lbl_CUIT);
            splitContainer1.Panel2.Controls.Add(lbl_PuntoVenta);
            splitContainer1.Size = new Size(579, 137);
            splitContainer1.SplitterDistance = 281;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 10;
            // 
            // CondIVAClub
            // 
            CondIVAClub.BackColor = SystemColors.Control;
            CondIVAClub.BorderStyle = BorderStyle.None;
            CondIVAClub.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CondIVAClub.Location = new Point(145, 116);
            CondIVAClub.Margin = new Padding(1);
            CondIVAClub.Name = "CondIVAClub";
            CondIVAClub.Size = new Size(132, 15);
            CondIVAClub.TabIndex = 13;
            CondIVAClub.Text = "Responsable Inscripto";
            // 
            // lbl_CondIVA
            // 
            lbl_CondIVA.AutoSize = true;
            lbl_CondIVA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CondIVA.Location = new Point(1, 116);
            lbl_CondIVA.Margin = new Padding(1, 0, 1, 0);
            lbl_CondIVA.Name = "lbl_CondIVA";
            lbl_CondIVA.Size = new Size(137, 15);
            lbl_CondIVA.TabIndex = 12;
            lbl_CondIVA.Text = "Condicion frente al IVA:";
            // 
            // DomComercial
            // 
            DomComercial.BackColor = SystemColors.Control;
            DomComercial.BorderStyle = BorderStyle.None;
            DomComercial.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DomComercial.Location = new Point(130, 94);
            DomComercial.Margin = new Padding(1);
            DomComercial.Name = "DomComercial";
            DomComercial.Size = new Size(141, 15);
            DomComercial.TabIndex = 12;
            DomComercial.Text = "Gaona 1111, CABA";
            // 
            // lbl_DomComercial
            // 
            lbl_DomComercial.AutoSize = true;
            lbl_DomComercial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DomComercial.Location = new Point(1, 93);
            lbl_DomComercial.Margin = new Padding(1, 0, 1, 0);
            lbl_DomComercial.Name = "lbl_DomComercial";
            lbl_DomComercial.Size = new Size(120, 15);
            lbl_DomComercial.TabIndex = 11;
            lbl_DomComercial.Text = "Domicilio Comercial:";
            // 
            // NombreFantasia
            // 
            NombreFantasia.BackColor = SystemColors.Control;
            NombreFantasia.BorderStyle = BorderStyle.None;
            NombreFantasia.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NombreFantasia.Location = new Point(83, 12);
            NombreFantasia.Margin = new Padding(1);
            NombreFantasia.Name = "NombreFantasia";
            NombreFantasia.Size = new Size(141, 20);
            NombreFantasia.TabIndex = 10;
            NombreFantasia.Text = "Sports Club ";
            NombreFantasia.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_RazonSocial
            // 
            lbl_RazonSocial.AutoSize = true;
            lbl_RazonSocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_RazonSocial.Location = new Point(1, 71);
            lbl_RazonSocial.Margin = new Padding(1, 0, 1, 0);
            lbl_RazonSocial.Name = "lbl_RazonSocial";
            lbl_RazonSocial.Size = new Size(79, 15);
            lbl_RazonSocial.TabIndex = 9;
            lbl_RazonSocial.Text = "Razon Social:";
            // 
            // txt_fechaComprobante
            // 
            txt_fechaComprobante.BackColor = SystemColors.Control;
            txt_fechaComprobante.Location = new Point(143, 38);
            txt_fechaComprobante.Margin = new Padding(1);
            txt_fechaComprobante.Name = "txt_fechaComprobante";
            txt_fechaComprobante.Size = new Size(139, 23);
            txt_fechaComprobante.TabIndex = 20;
            // 
            // CUIT
            // 
            CUIT.BackColor = SystemColors.Control;
            CUIT.BorderStyle = BorderStyle.None;
            CUIT.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CUIT.Location = new Point(88, 72);
            CUIT.Margin = new Padding(1);
            CUIT.Name = "CUIT";
            CUIT.Size = new Size(83, 15);
            CUIT.TabIndex = 13;
            CUIT.Text = "30-873653-9";
            // 
            // FechaInicioAct
            // 
            FechaInicioAct.BackColor = SystemColors.Control;
            FechaInicioAct.BorderStyle = BorderStyle.None;
            FechaInicioAct.Font = new Font("Century Gothic", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            FechaInicioAct.Location = new Point(215, 115);
            FechaInicioAct.Margin = new Padding(1);
            FechaInicioAct.Name = "FechaInicioAct";
            FechaInicioAct.Size = new Size(76, 17);
            FechaInicioAct.TabIndex = 17;
            FechaInicioAct.Text = "01/01/2005";
            // 
            // IIBB
            // 
            IIBB.BackColor = SystemColors.Control;
            IIBB.BorderStyle = BorderStyle.None;
            IIBB.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IIBB.Location = new Point(141, 95);
            IIBB.Margin = new Padding(1);
            IIBB.Name = "IIBB";
            IIBB.Size = new Size(132, 15);
            IIBB.TabIndex = 14;
            IIBB.Text = "Exento";
            // 
            // txt_NroComp
            // 
            txt_NroComp.BackColor = SystemColors.Control;
            txt_NroComp.BorderStyle = BorderStyle.None;
            txt_NroComp.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_NroComp.Location = new Point(230, 10);
            txt_NroComp.Margin = new Padding(1);
            txt_NroComp.Name = "txt_NroComp";
            txt_NroComp.Size = new Size(60, 15);
            txt_NroComp.TabIndex = 15;
            // 
            // lbl_NroComp
            // 
            lbl_NroComp.AutoSize = true;
            lbl_NroComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NroComp.Location = new Point(154, 9);
            lbl_NroComp.Margin = new Padding(1, 0, 1, 0);
            lbl_NroComp.Name = "lbl_NroComp";
            lbl_NroComp.Size = new Size(69, 15);
            lbl_NroComp.TabIndex = 12;
            lbl_NroComp.Text = "Comp. Nro:";
            // 
            // PtoVenta
            // 
            PtoVenta.BackColor = SystemColors.Control;
            PtoVenta.BorderStyle = BorderStyle.None;
            PtoVenta.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PtoVenta.Location = new Point(128, 10);
            PtoVenta.Margin = new Padding(1);
            PtoVenta.Name = "PtoVenta";
            PtoVenta.Size = new Size(27, 15);
            PtoVenta.TabIndex = 14;
            PtoVenta.Text = "001";
            // 
            // lbl_FechaInicioAct
            // 
            lbl_FechaInicioAct.AutoSize = true;
            lbl_FechaInicioAct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FechaInicioAct.Location = new Point(31, 115);
            lbl_FechaInicioAct.Margin = new Padding(1, 0, 1, 0);
            lbl_FechaInicioAct.Name = "lbl_FechaInicioAct";
            lbl_FechaInicioAct.Size = new Size(176, 15);
            lbl_FechaInicioAct.TabIndex = 12;
            lbl_FechaInicioAct.Text = "Fecha de Inicio de Actividades:";
            // 
            // lbl_IIBB
            // 
            lbl_IIBB.AutoSize = true;
            lbl_IIBB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IIBB.Location = new Point(31, 93);
            lbl_IIBB.Margin = new Padding(1, 0, 1, 0);
            lbl_IIBB.Name = "lbl_IIBB";
            lbl_IIBB.Size = new Size(97, 15);
            lbl_IIBB.TabIndex = 12;
            lbl_IIBB.Text = "Ingresos Brutos:";
            // 
            // lbl_CUIT
            // 
            lbl_CUIT.AutoSize = true;
            lbl_CUIT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CUIT.Location = new Point(31, 71);
            lbl_CUIT.Margin = new Padding(1, 0, 1, 0);
            lbl_CUIT.Name = "lbl_CUIT";
            lbl_CUIT.Size = new Size(37, 15);
            lbl_CUIT.TabIndex = 12;
            lbl_CUIT.Text = "CUIT:";
            // 
            // lbl_PuntoVenta
            // 
            lbl_PuntoVenta.AutoSize = true;
            lbl_PuntoVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PuntoVenta.Location = new Point(31, 9);
            lbl_PuntoVenta.Margin = new Padding(1, 0, 1, 0);
            lbl_PuntoVenta.Name = "lbl_PuntoVenta";
            lbl_PuntoVenta.Size = new Size(95, 15);
            lbl_PuntoVenta.TabIndex = 11;
            lbl_PuntoVenta.Text = "Punto de Venta:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_formaPago);
            panel1.Controls.Add(txt_proximoVencimiento);
            panel1.Controls.Add(txt_frecuenciaPago);
            panel1.Controls.Add(txt_dni);
            panel1.Controls.Add(txt_nombreCliente);
            panel1.Controls.Add(lbl_NombreCliente);
            panel1.Controls.Add(CondIVACliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_DNICliente);
            panel1.Controls.Add(lbl_formaPago);
            panel1.Controls.Add(lblTipoPago);
            panel1.Controls.Add(lblProximoVencimiento);
            panel1.Location = new Point(30, 200);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 91);
            panel1.TabIndex = 11;
            // 
            // txt_formaPago
            // 
            txt_formaPago.BackColor = SystemColors.Control;
            txt_formaPago.Location = new Point(138, 31);
            txt_formaPago.Margin = new Padding(1);
            txt_formaPago.Name = "txt_formaPago";
            txt_formaPago.Size = new Size(139, 23);
            txt_formaPago.TabIndex = 19;
            txt_formaPago.TextChanged += txt_formaPago_TextChanged;
            // 
            // txt_proximoVencimiento
            // 
            txt_proximoVencimiento.BackColor = SystemColors.Control;
            txt_proximoVencimiento.Location = new Point(450, 60);
            txt_proximoVencimiento.Margin = new Padding(1);
            txt_proximoVencimiento.Name = "txt_proximoVencimiento";
            txt_proximoVencimiento.Size = new Size(120, 23);
            txt_proximoVencimiento.TabIndex = 18;
            // 
            // txt_frecuenciaPago
            // 
            txt_frecuenciaPago.BackColor = SystemColors.Control;
            txt_frecuenciaPago.Location = new Point(138, 60);
            txt_frecuenciaPago.Margin = new Padding(1);
            txt_frecuenciaPago.Name = "txt_frecuenciaPago";
            txt_frecuenciaPago.Size = new Size(139, 23);
            txt_frecuenciaPago.TabIndex = 17;
            // 
            // txt_dni
            // 
            txt_dni.BackColor = SystemColors.Control;
            txt_dni.Location = new Point(357, 30);
            txt_dni.Margin = new Padding(1);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(139, 23);
            txt_dni.TabIndex = 16;
            // 
            // txt_nombreCliente
            // 
            txt_nombreCliente.BackColor = SystemColors.Control;
            txt_nombreCliente.Location = new Point(431, 7);
            txt_nombreCliente.Margin = new Padding(1);
            txt_nombreCliente.Name = "txt_nombreCliente";
            txt_nombreCliente.Size = new Size(139, 23);
            txt_nombreCliente.TabIndex = 15;
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreCliente.Location = new Point(313, 7);
            lbl_NombreCliente.Margin = new Padding(1, 0, 1, 0);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(113, 15);
            lbl_NombreCliente.TabIndex = 12;
            lbl_NombreCliente.Text = "Apellido y Nombre:";
            // 
            // CondIVACliente
            // 
            CondIVACliente.BackColor = SystemColors.Control;
            CondIVACliente.BorderStyle = BorderStyle.None;
            CondIVACliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CondIVACliente.Location = new Point(153, 10);
            CondIVACliente.Margin = new Padding(1);
            CondIVACliente.Name = "CondIVACliente";
            CondIVACliente.Size = new Size(132, 15);
            CondIVACliente.TabIndex = 14;
            CondIVACliente.Text = "Consumidor Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 9);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 13;
            label1.Text = "Condicion frente al IVA:";
            // 
            // lbl_DNICliente
            // 
            lbl_DNICliente.AutoSize = true;
            lbl_DNICliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DNICliente.Location = new Point(313, 33);
            lbl_DNICliente.Margin = new Padding(1, 0, 1, 0);
            lbl_DNICliente.Name = "lbl_DNICliente";
            lbl_DNICliente.Size = new Size(32, 15);
            lbl_DNICliente.TabIndex = 10;
            lbl_DNICliente.Text = "DNI:";
            // 
            // dgvActividades
            // 
            dgvActividades.BackgroundColor = SystemColors.Control;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.ColumnHeadersVisible = false;
            dgvActividades.Columns.AddRange(new DataGridViewColumn[] { Codigo, Clase, PrecioUnitario, Bonificacion, Subtotal });
            dgvActividades.Location = new Point(30, 310);
            dgvActividades.Margin = new Padding(1);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowHeadersVisible = false;
            dgvActividades.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvActividades.RowTemplate.Height = 49;
            dgvActividades.Size = new Size(580, 94);
            dgvActividades.TabIndex = 18;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 12;
            Codigo.Name = "Codigo";
            Codigo.Width = 170;
            // 
            // Clase
            // 
            Clase.HeaderText = "Clase";
            Clase.MinimumWidth = 12;
            Clase.Name = "Clase";
            Clase.Width = 292;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.MinimumWidth = 12;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.Width = 320;
            // 
            // Bonificacion
            // 
            Bonificacion.HeaderText = "Bonificacion";
            Bonificacion.MinimumWidth = 12;
            Bonificacion.Name = "Bonificacion";
            Bonificacion.Width = 286;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 12;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 337;
            // 
            // lbl_CodAct
            // 
            lbl_CodAct.BackColor = SystemColors.ScrollBar;
            lbl_CodAct.BorderStyle = BorderStyle.FixedSingle;
            lbl_CodAct.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CodAct.Location = new Point(30, 290);
            lbl_CodAct.Margin = new Padding(1);
            lbl_CodAct.Name = "lbl_CodAct";
            lbl_CodAct.Size = new Size(76, 27);
            lbl_CodAct.TabIndex = 13;
            lbl_CodAct.Text = "Codigo";
            lbl_CodAct.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(100, 290);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            textBox1.Text = "  Clase";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Lbl_Bonificacion
            // 
            Lbl_Bonificacion.BackColor = SystemColors.ScrollBar;
            Lbl_Bonificacion.BorderStyle = BorderStyle.FixedSingle;
            Lbl_Bonificacion.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Bonificacion.Location = new Point(349, 290);
            Lbl_Bonificacion.Margin = new Padding(1);
            Lbl_Bonificacion.Name = "Lbl_Bonificacion";
            Lbl_Bonificacion.Size = new Size(130, 27);
            Lbl_Bonificacion.TabIndex = 15;
            Lbl_Bonificacion.Text = "   Bonificacion";
            Lbl_Bonificacion.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_PrecioUnit
            // 
            lbl_PrecioUnit.BackColor = SystemColors.ScrollBar;
            lbl_PrecioUnit.BorderStyle = BorderStyle.FixedSingle;
            lbl_PrecioUnit.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PrecioUnit.Location = new Point(220, 290);
            lbl_PrecioUnit.Margin = new Padding(1);
            lbl_PrecioUnit.Name = "lbl_PrecioUnit";
            lbl_PrecioUnit.Size = new Size(135, 27);
            lbl_PrecioUnit.TabIndex = 16;
            lbl_PrecioUnit.Text = "  Precio Unitario";
            lbl_PrecioUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.BackColor = SystemColors.ScrollBar;
            lbl_Subtotal.BorderStyle = BorderStyle.FixedSingle;
            lbl_Subtotal.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal.Location = new Point(470, 290);
            lbl_Subtotal.Margin = new Padding(1);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(141, 27);
            lbl_Subtotal.TabIndex = 17;
            lbl_Subtotal.Text = "   Subtotal";
            lbl_Subtotal.TextAlign = HorizontalAlignment.Center;
            // 
            // Btn_ImprimirComprobante
            // 
            Btn_ImprimirComprobante.BackColor = SystemColors.Control;
            Btn_ImprimirComprobante.Cursor = Cursors.Hand;
            Btn_ImprimirComprobante.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_ImprimirComprobante.Location = new Point(247, 460);
            Btn_ImprimirComprobante.Margin = new Padding(1);
            Btn_ImprimirComprobante.Name = "Btn_ImprimirComprobante";
            Btn_ImprimirComprobante.Size = new Size(146, 31);
            Btn_ImprimirComprobante.TabIndex = 19;
            Btn_ImprimirComprobante.Text = "Imprimir";
            Btn_ImprimirComprobante.UseVisualStyleBackColor = false;
            Btn_ImprimirComprobante.Click += Btn_ImprimirComprobante_Click;
            Btn_ImprimirComprobante.MouseEnter += ImprimirComprobante_MouseEnter;
            Btn_ImprimirComprobante.MouseLeave += ImprimirComprobante_MouseLeave;
            // 
            // Btn_cerrar
            // 
            Btn_cerrar.Cursor = Cursors.Hand;
            Btn_cerrar.Image = (Image)resources.GetObject("Btn_cerrar.Image");
            Btn_cerrar.Location = new Point(607, 0);
            Btn_cerrar.Margin = new Padding(1);
            Btn_cerrar.Name = "Btn_cerrar";
            Btn_cerrar.Size = new Size(32, 20);
            Btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_cerrar.TabIndex = 20;
            Btn_cerrar.TabStop = false;
            Btn_cerrar.Click += Btn_cerrar_Click;
            // 
            // Btn_minimizar
            // 
            Btn_minimizar.Cursor = Cursors.Hand;
            Btn_minimizar.Image = (Image)resources.GetObject("Btn_minimizar.Image");
            Btn_minimizar.Location = new Point(576, 0);
            Btn_minimizar.Margin = new Padding(1);
            Btn_minimizar.Name = "Btn_minimizar";
            Btn_minimizar.Size = new Size(32, 20);
            Btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_minimizar.TabIndex = 21;
            Btn_minimizar.TabStop = false;
            Btn_minimizar.Click += Btn_minimizar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_total);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(30, 406);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 43);
            panel2.TabIndex = 22;
            // 
            // textBox_total
            // 
            textBox_total.BackColor = SystemColors.Control;
            textBox_total.Location = new Point(431, 7);
            textBox_total.Margin = new Padding(1);
            textBox_total.Name = "textBox_total";
            textBox_total.Size = new Size(139, 23);
            textBox_total.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(385, 10);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 12;
            label2.Text = "Total $";
            // 
            // ComprobantePago_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 506);
            Controls.Add(panel2);
            Controls.Add(Btn_minimizar);
            Controls.Add(Btn_cerrar);
            Controls.Add(Btn_ImprimirComprobante);
            Controls.Add(dgvActividades);
            Controls.Add(lbl_Subtotal);
            Controls.Add(lbl_PrecioUnit);
            Controls.Add(Lbl_Bonificacion);
            Controls.Add(textBox1);
            Controls.Add(lbl_CodAct);
            Controls.Add(panel1);
            Controls.Add(TipoFct);
            Controls.Add(splitContainer1);
            Controls.Add(FctOriginal);
            Controls.Add(lblMonto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "ComprobantePago_Form";
            Text = "ComprobantePago_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_minimizar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblFechaPago;
        private Label lblProximoVencimiento;
        private Label lblTipoPago;
        private Label lbl_formaPago;
        private PictureBox pictureBox1;
        private TextBox FctOriginal;
        private TextBox RazonSocial;
        private TextBox TipoFct;
        private SplitContainer splitContainer1;
        private Label lbl_RazonSocial;
        private Label lbl_DomComercial;
        private TextBox NombreFantasia;
        private TextBox CondIVAClub;
        private Label lbl_CondIVA;
        private TextBox DomComercial;
        private Label lbl_FechaInicioAct;
        private Label lbl_IIBB;
        private Label lbl_CUIT;
        private Label lbl_PuntoVenta;
        private TextBox txt_NroComp;
        private Label lbl_NroComp;
        private TextBox PtoVenta;
        private TextBox CUIT;
        private TextBox FechaInicioAct;
        private TextBox IIBB;
        private Panel panel1;
        private Label lbl_DNICliente;
        private TextBox CondIVACliente;
        private Label label1;
        private Label lbl_NombreCliente;
        private Label lbl_IdActividad;
        private TextBox lbl_CodAct;
        private TextBox textBox1;
        private TextBox Lbl_Bonificacion;
        private TextBox lbl_PrecioUnit;
        private TextBox lbl_Subtotal;
        private DataGridView dgvActividades;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Clase;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Bonificacion;
        private DataGridViewTextBoxColumn Subtotal;
        private Button Btn_ImprimirComprobante;
        private PictureBox Btn_cerrar;
        private PictureBox Btn_minimizar;
        private TextBox txt_nombreCliente;
        private TextBox txt_dni;
        private TextBox txt_frecuenciaPago;
        private TextBox txt_proximoVencimiento;
        private TextBox txt_formaPago;
        private TextBox txt_fechaComprobante;
        private Panel panel2;
        private TextBox textBox_total;
        private Label label2;
    }
}