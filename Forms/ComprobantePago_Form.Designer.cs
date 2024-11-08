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
            CUIT = new TextBox();
            FechaInicioAct = new TextBox();
            IIBB = new TextBox();
            NroComp = new TextBox();
            lbl_NroComp = new Label();
            PtoVenta = new TextBox();
            lbl_FechaInicioAct = new Label();
            lbl_IIBB = new Label();
            lbl_CUIT = new Label();
            lbl_PuntoVenta = new Label();
            panel1 = new Panel();
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
            ImprimirComprobante = new Button();
            Btn_cerrar = new PictureBox();
            Btn_minimizar = new PictureBox();
            txt_formaPago = new TextBox();
            txt_fechaComprobante = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_minimizar).BeginInit();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(123, 707);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(108, 41);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaPago.Location = new Point(75, 111);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(267, 41);
            lblFechaPago.TabIndex = 1;
            lblFechaPago.Text = "Fecha de Emision:";
            // 
            // lblProximoVencimiento
            // 
            lblProximoVencimiento.AutoSize = true;
            lblProximoVencimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProximoVencimiento.Location = new Point(760, 168);
            lblProximoVencimiento.Name = "lblProximoVencimiento";
            lblProximoVencimiento.Size = new Size(327, 41);
            lblProximoVencimiento.TabIndex = 2;
            lblProximoVencimiento.Text = "Proximo Vencimiento:";
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoPago.Location = new Point(13, 171);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(296, 41);
            lblTipoPago.TabIndex = 3;
            lblTipoPago.Text = "Frecuencia de Pago:";
            // 
            // lbl_formaPago
            // 
            lbl_formaPago.AutoSize = true;
            lbl_formaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_formaPago.Location = new Point(13, 89);
            lbl_formaPago.Name = "lbl_formaPago";
            lbl_formaPago.Size = new Size(289, 41);
            lbl_formaPago.TabIndex = 5;
            lbl_formaPago.Text = "Condicion de Pago:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sports_club_logo;
            pictureBox1.Location = new Point(16, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FctOriginal
            // 
            FctOriginal.BackColor = SystemColors.Control;
            FctOriginal.BorderStyle = BorderStyle.FixedSingle;
            FctOriginal.Font = new Font("Century Gothic", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            FctOriginal.Location = new Point(69, 82);
            FctOriginal.Name = "FctOriginal";
            FctOriginal.Size = new Size(1407, 90);
            FctOriginal.TabIndex = 7;
            FctOriginal.Text = "ORIGINAL";
            FctOriginal.TextAlign = HorizontalAlignment.Center;
            // 
            // RazonSocial
            // 
            RazonSocial.BackColor = SystemColors.Control;
            RazonSocial.BorderStyle = BorderStyle.None;
            RazonSocial.Font = new Font("Century Gothic", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            RazonSocial.Location = new Point(212, 194);
            RazonSocial.Name = "RazonSocial";
            RazonSocial.Size = new Size(343, 41);
            RazonSocial.TabIndex = 8;
            RazonSocial.Text = "ArgySports S.R.L.";
            // 
            // TipoFct
            // 
            TipoFct.BackColor = SystemColors.Control;
            TipoFct.BorderStyle = BorderStyle.FixedSingle;
            TipoFct.Font = new Font("Century Gothic", 21.9F, FontStyle.Bold, GraphicsUnit.Point);
            TipoFct.Location = new Point(693, 168);
            TipoFct.Name = "TipoFct";
            TipoFct.Size = new Size(120, 97);
            TipoFct.TabIndex = 9;
            TipoFct.Text = "X";
            TipoFct.TextAlign = HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(69, 168);
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
            splitContainer1.Panel2.Controls.Add(NroComp);
            splitContainer1.Panel2.Controls.Add(lbl_NroComp);
            splitContainer1.Panel2.Controls.Add(PtoVenta);
            splitContainer1.Panel2.Controls.Add(lbl_FechaInicioAct);
            splitContainer1.Panel2.Controls.Add(lblFechaPago);
            splitContainer1.Panel2.Controls.Add(lbl_IIBB);
            splitContainer1.Panel2.Controls.Add(lbl_CUIT);
            splitContainer1.Panel2.Controls.Add(lbl_PuntoVenta);
            splitContainer1.Size = new Size(1407, 374);
            splitContainer1.SplitterDistance = 684;
            splitContainer1.TabIndex = 10;
            // 
            // CondIVAClub
            // 
            CondIVAClub.BackColor = SystemColors.Control;
            CondIVAClub.BorderStyle = BorderStyle.None;
            CondIVAClub.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CondIVAClub.Location = new Point(351, 318);
            CondIVAClub.Name = "CondIVAClub";
            CondIVAClub.Size = new Size(320, 37);
            CondIVAClub.TabIndex = 13;
            CondIVAClub.Text = "Responsable Inscripto";
            // 
            // lbl_CondIVA
            // 
            lbl_CondIVA.AutoSize = true;
            lbl_CondIVA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CondIVA.Location = new Point(3, 316);
            lbl_CondIVA.Name = "lbl_CondIVA";
            lbl_CondIVA.Size = new Size(352, 41);
            lbl_CondIVA.TabIndex = 12;
            lbl_CondIVA.Text = "Condicion frente al IVA:";
            // 
            // DomComercial
            // 
            DomComercial.BackColor = SystemColors.Control;
            DomComercial.BorderStyle = BorderStyle.None;
            DomComercial.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DomComercial.Location = new Point(315, 257);
            DomComercial.Name = "DomComercial";
            DomComercial.Size = new Size(343, 37);
            DomComercial.TabIndex = 12;
            DomComercial.Text = "Gaona 1111, CABA";
            // 
            // lbl_DomComercial
            // 
            lbl_DomComercial.AutoSize = true;
            lbl_DomComercial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DomComercial.Location = new Point(3, 253);
            lbl_DomComercial.Name = "lbl_DomComercial";
            lbl_DomComercial.Size = new Size(309, 41);
            lbl_DomComercial.TabIndex = 11;
            lbl_DomComercial.Text = "Domicilio Comercial:";
            // 
            // NombreFantasia
            // 
            NombreFantasia.BackColor = SystemColors.Control;
            NombreFantasia.BorderStyle = BorderStyle.None;
            NombreFantasia.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            NombreFantasia.Location = new Point(201, 33);
            NombreFantasia.Name = "NombreFantasia";
            NombreFantasia.Size = new Size(343, 50);
            NombreFantasia.TabIndex = 10;
            NombreFantasia.Text = "Sports Club ";
            NombreFantasia.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_RazonSocial
            // 
            lbl_RazonSocial.AutoSize = true;
            lbl_RazonSocial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_RazonSocial.Location = new Point(3, 194);
            lbl_RazonSocial.Name = "lbl_RazonSocial";
            lbl_RazonSocial.Size = new Size(203, 41);
            lbl_RazonSocial.TabIndex = 9;
            lbl_RazonSocial.Text = "Razon Social:";
            // 
            // CUIT
            // 
            CUIT.BackColor = SystemColors.Control;
            CUIT.BorderStyle = BorderStyle.None;
            CUIT.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CUIT.Location = new Point(214, 196);
            CUIT.Name = "CUIT";
            CUIT.Size = new Size(201, 37);
            CUIT.TabIndex = 13;
            CUIT.Text = "30-873653-9";
            // 
            // FechaInicioAct
            // 
            FechaInicioAct.BackColor = SystemColors.Control;
            FechaInicioAct.BorderStyle = BorderStyle.None;
            FechaInicioAct.Font = new Font("Century Gothic", 9.900001F, FontStyle.Regular, GraphicsUnit.Point);
            FechaInicioAct.Location = new Point(521, 315);
            FechaInicioAct.Name = "FechaInicioAct";
            FechaInicioAct.Size = new Size(185, 41);
            FechaInicioAct.TabIndex = 17;
            FechaInicioAct.Text = "01/01/2005";
            // 
            // IIBB
            // 
            IIBB.BackColor = SystemColors.Control;
            IIBB.BorderStyle = BorderStyle.None;
            IIBB.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IIBB.Location = new Point(342, 259);
            IIBB.Name = "IIBB";
            IIBB.Size = new Size(320, 37);
            IIBB.TabIndex = 14;
            IIBB.Text = "Exento";
            // 
            // NroComp
            // 
            NroComp.BackColor = SystemColors.Control;
            NroComp.BorderStyle = BorderStyle.None;
            NroComp.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NroComp.Location = new Point(549, 29);
            NroComp.Name = "NroComp";
            NroComp.Size = new Size(145, 37);
            NroComp.TabIndex = 15;
            NroComp.Text = "00000001";
            // 
            // lbl_NroComp
            // 
            lbl_NroComp.AutoSize = true;
            lbl_NroComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NroComp.Location = new Point(374, 25);
            lbl_NroComp.Name = "lbl_NroComp";
            lbl_NroComp.Size = new Size(179, 41);
            lbl_NroComp.TabIndex = 12;
            lbl_NroComp.Text = "Comp. Nro:";
            // 
            // PtoVenta
            // 
            PtoVenta.BackColor = SystemColors.Control;
            PtoVenta.BorderStyle = BorderStyle.None;
            PtoVenta.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PtoVenta.Location = new Point(312, 27);
            PtoVenta.Name = "PtoVenta";
            PtoVenta.Size = new Size(66, 37);
            PtoVenta.TabIndex = 14;
            PtoVenta.Text = "001";
            // 
            // lbl_FechaInicioAct
            // 
            lbl_FechaInicioAct.AutoSize = true;
            lbl_FechaInicioAct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FechaInicioAct.Location = new Point(75, 314);
            lbl_FechaInicioAct.Name = "lbl_FechaInicioAct";
            lbl_FechaInicioAct.Size = new Size(450, 41);
            lbl_FechaInicioAct.TabIndex = 12;
            lbl_FechaInicioAct.Text = "Fecha de Inicio de Actividades:";
            // 
            // lbl_IIBB
            // 
            lbl_IIBB.AutoSize = true;
            lbl_IIBB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IIBB.Location = new Point(75, 255);
            lbl_IIBB.Name = "lbl_IIBB";
            lbl_IIBB.Size = new Size(245, 41);
            lbl_IIBB.TabIndex = 12;
            lbl_IIBB.Text = "Ingresos Brutos:";
            // 
            // lbl_CUIT
            // 
            lbl_CUIT.AutoSize = true;
            lbl_CUIT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CUIT.Location = new Point(75, 194);
            lbl_CUIT.Name = "lbl_CUIT";
            lbl_CUIT.Size = new Size(95, 41);
            lbl_CUIT.TabIndex = 12;
            lbl_CUIT.Text = "CUIT:";
            // 
            // lbl_PuntoVenta
            // 
            lbl_PuntoVenta.AutoSize = true;
            lbl_PuntoVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PuntoVenta.Location = new Point(75, 25);
            lbl_PuntoVenta.Name = "lbl_PuntoVenta";
            lbl_PuntoVenta.Size = new Size(241, 41);
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
            panel1.Location = new Point(72, 548);
            panel1.Name = "panel1";
            panel1.Size = new Size(1407, 250);
            panel1.TabIndex = 11;
            // 
            // txt_proximoVencimiento
            // 
            txt_proximoVencimiento.BackColor = SystemColors.Control;
            txt_proximoVencimiento.Location = new Point(1093, 165);
            txt_proximoVencimiento.Name = "txt_proximoVencimiento";
            txt_proximoVencimiento.Size = new Size(286, 47);
            txt_proximoVencimiento.TabIndex = 18;
            // 
            // txt_frecuenciaPago
            // 
            txt_frecuenciaPago.BackColor = SystemColors.Control;
            txt_frecuenciaPago.Location = new Point(336, 165);
            txt_frecuenciaPago.Name = "txt_frecuenciaPago";
            txt_frecuenciaPago.Size = new Size(332, 47);
            txt_frecuenciaPago.TabIndex = 17;
            // 
            // txt_dni
            // 
            txt_dni.BackColor = SystemColors.Control;
            txt_dni.Location = new Point(867, 83);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(332, 47);
            txt_dni.TabIndex = 16;
            // 
            // txt_nombreCliente
            // 
            txt_nombreCliente.BackColor = SystemColors.Control;
            txt_nombreCliente.Location = new Point(1047, 18);
            txt_nombreCliente.Name = "txt_nombreCliente";
            txt_nombreCliente.Size = new Size(332, 47);
            txt_nombreCliente.TabIndex = 15;
            // 
            // lbl_NombreCliente
            // 
            lbl_NombreCliente.AutoSize = true;
            lbl_NombreCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NombreCliente.Location = new Point(760, 18);
            lbl_NombreCliente.Name = "lbl_NombreCliente";
            lbl_NombreCliente.Size = new Size(294, 41);
            lbl_NombreCliente.TabIndex = 12;
            lbl_NombreCliente.Text = "Apellido y Nombre:";
            // 
            // CondIVACliente
            // 
            CondIVACliente.BackColor = SystemColors.Control;
            CondIVACliente.BorderStyle = BorderStyle.None;
            CondIVACliente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CondIVACliente.Location = new Point(371, 26);
            CondIVACliente.Name = "CondIVACliente";
            CondIVACliente.Size = new Size(320, 37);
            CondIVACliente.TabIndex = 14;
            CondIVACliente.Text = "Consumidor Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(352, 41);
            label1.TabIndex = 13;
            label1.Text = "Condicion frente al IVA:";
            // 
            // lbl_DNICliente
            // 
            lbl_DNICliente.AutoSize = true;
            lbl_DNICliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DNICliente.Location = new Point(760, 89);
            lbl_DNICliente.Name = "lbl_DNICliente";
            lbl_DNICliente.Size = new Size(82, 41);
            lbl_DNICliente.TabIndex = 10;
            lbl_DNICliente.Text = "DNI:";
            // 
            // dgvActividades
            // 
            dgvActividades.BackgroundColor = SystemColors.Control;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.ColumnHeadersVisible = false;
            dgvActividades.Columns.AddRange(new DataGridViewColumn[] { Codigo, Clase, PrecioUnitario, Bonificacion, Subtotal });
            dgvActividades.Location = new Point(72, 847);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowHeadersVisible = false;
            dgvActividades.RowHeadersWidth = 102;
            dgvActividades.RowTemplate.Height = 49;
            dgvActividades.Size = new Size(1408, 258);
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
            lbl_CodAct.Location = new Point(72, 793);
            lbl_CodAct.Name = "lbl_CodAct";
            lbl_CodAct.Size = new Size(181, 57);
            lbl_CodAct.TabIndex = 13;
            lbl_CodAct.Text = "Codigo";
            lbl_CodAct.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(242, 793);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 57);
            textBox1.TabIndex = 14;
            textBox1.Text = "  Clase";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Lbl_Bonificacion
            // 
            Lbl_Bonificacion.BackColor = SystemColors.ScrollBar;
            Lbl_Bonificacion.BorderStyle = BorderStyle.FixedSingle;
            Lbl_Bonificacion.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Bonificacion.Location = new Point(848, 793);
            Lbl_Bonificacion.Name = "Lbl_Bonificacion";
            Lbl_Bonificacion.Size = new Size(312, 57);
            Lbl_Bonificacion.TabIndex = 15;
            Lbl_Bonificacion.Text = "   Bonificacion";
            Lbl_Bonificacion.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_PrecioUnit
            // 
            lbl_PrecioUnit.BackColor = SystemColors.ScrollBar;
            lbl_PrecioUnit.BorderStyle = BorderStyle.FixedSingle;
            lbl_PrecioUnit.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PrecioUnit.Location = new Point(535, 793);
            lbl_PrecioUnit.Name = "lbl_PrecioUnit";
            lbl_PrecioUnit.Size = new Size(325, 57);
            lbl_PrecioUnit.TabIndex = 16;
            lbl_PrecioUnit.Text = "  Precio Unitario";
            lbl_PrecioUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_Subtotal
            // 
            lbl_Subtotal.BackColor = SystemColors.ScrollBar;
            lbl_Subtotal.BorderStyle = BorderStyle.FixedSingle;
            lbl_Subtotal.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Subtotal.Location = new Point(1141, 793);
            lbl_Subtotal.Name = "lbl_Subtotal";
            lbl_Subtotal.Size = new Size(339, 57);
            lbl_Subtotal.TabIndex = 17;
            lbl_Subtotal.Text = "   Subtotal";
            lbl_Subtotal.TextAlign = HorizontalAlignment.Center;
            // 
            // ImprimirComprobante
            // 
            ImprimirComprobante.BackColor = SystemColors.Control;
            ImprimirComprobante.Cursor = Cursors.Hand;
            ImprimirComprobante.Font = new Font("Century Gothic", 11.1F, FontStyle.Bold, GraphicsUnit.Point);
            ImprimirComprobante.Location = new Point(560, 1134);
            ImprimirComprobante.Name = "ImprimirComprobante";
            ImprimirComprobante.Size = new Size(354, 58);
            ImprimirComprobante.TabIndex = 19;
            ImprimirComprobante.Text = "Imprimir";
            ImprimirComprobante.UseVisualStyleBackColor = false;
            ImprimirComprobante.MouseEnter += ImprimirComprobante_MouseEnter;
            ImprimirComprobante.MouseLeave += ImprimirComprobante_MouseLeave;
            // 
            // Btn_cerrar
            // 
            Btn_cerrar.Cursor = Cursors.Hand;
            Btn_cerrar.Image = (Image)resources.GetObject("Btn_cerrar.Image");
            Btn_cerrar.Location = new Point(1473, 0);
            Btn_cerrar.Margin = new Padding(2, 3, 2, 3);
            Btn_cerrar.Name = "Btn_cerrar";
            Btn_cerrar.Size = new Size(78, 55);
            Btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_cerrar.TabIndex = 20;
            Btn_cerrar.TabStop = false;
            Btn_cerrar.Click += Btn_cerrar_Click;
            // 
            // Btn_minimizar
            // 
            Btn_minimizar.Cursor = Cursors.Hand;
            Btn_minimizar.Image = (Image)resources.GetObject("Btn_minimizar.Image");
            Btn_minimizar.Location = new Point(1398, 0);
            Btn_minimizar.Margin = new Padding(2, 3, 2, 3);
            Btn_minimizar.Name = "Btn_minimizar";
            Btn_minimizar.Size = new Size(78, 55);
            Btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_minimizar.TabIndex = 21;
            Btn_minimizar.TabStop = false;
            Btn_minimizar.Click += Btn_minimizar_Click;
            // 
            // txt_formaPago
            // 
            txt_formaPago.BackColor = SystemColors.Control;
            txt_formaPago.Location = new Point(336, 86);
            txt_formaPago.Name = "txt_formaPago";
            txt_formaPago.Size = new Size(332, 47);
            txt_formaPago.TabIndex = 19;
            txt_formaPago.TextChanged += txt_formaPago_TextChanged;
            // 
            // txt_fechaComprobante
            // 
            txt_fechaComprobante.BackColor = SystemColors.Control;
            txt_fechaComprobante.Location = new Point(348, 105);
            txt_fechaComprobante.Name = "txt_fechaComprobante";
            txt_fechaComprobante.Size = new Size(332, 47);
            txt_fechaComprobante.TabIndex = 20;
            // 
            // ComprobantePago_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 1231);
            Controls.Add(Btn_minimizar);
            Controls.Add(Btn_cerrar);
            Controls.Add(ImprimirComprobante);
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
        private TextBox NroComp;
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
        private Button ImprimirComprobante;
        private PictureBox Btn_cerrar;
        private PictureBox Btn_minimizar;
        private TextBox txt_nombreCliente;
        private TextBox txt_dni;
        private TextBox txt_frecuenciaPago;
        private TextBox txt_proximoVencimiento;
        private TextBox txt_formaPago;
        private TextBox txt_fechaComprobante;
    }
}