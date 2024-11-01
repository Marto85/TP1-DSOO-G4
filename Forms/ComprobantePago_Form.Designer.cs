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
            lblMonto = new Label();
            lblFechaPago = new Label();
            lblProximoVencimiento = new Label();
            lblTipoPago = new Label();
            lstActividades = new ListBox();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(196, 130);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(108, 41);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(196, 216);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(95, 41);
            lblFechaPago.TabIndex = 1;
            lblFechaPago.Text = "Fecha";
            // 
            // lblProximoVencimiento
            // 
            lblProximoVencimiento.AutoSize = true;
            lblProximoVencimiento.Location = new Point(196, 396);
            lblProximoVencimiento.Name = "lblProximoVencimiento";
            lblProximoVencimiento.Size = new Size(301, 41);
            lblProximoVencimiento.TabIndex = 2;
            lblProximoVencimiento.Text = "Proximo Vencimiento";
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Location = new Point(196, 303);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new Size(194, 41);
            lblTipoPago.TabIndex = 3;
            lblTipoPago.Text = "Tipo de Pago";
            // 
            // lstActividades
            // 
            lstActividades.FormattingEnabled = true;
            lstActividades.ItemHeight = 41;
            lstActividades.Location = new Point(745, 130);
            lstActividades.Name = "lstActividades";
            lstActividades.Size = new Size(449, 332);
            lstActividades.TabIndex = 4;
            // 
            // ComprobantePago_Form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 678);
            Controls.Add(lstActividades);
            Controls.Add(lblTipoPago);
            Controls.Add(lblProximoVencimiento);
            Controls.Add(lblFechaPago);
            Controls.Add(lblMonto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComprobantePago_Form";
            Text = "ComprobantePago_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblFechaPago;
        private Label lblProximoVencimiento;
        private Label lblTipoPago;
        private ListBox lstActividades;
    }
}