namespace DSOO_Grupo4_TP1.Forms
{
    partial class Foto_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foto_form));
            Video_box = new PictureBox();
            panel2 = new Panel();
            Btn_Atras = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            BtnCapturarFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)Video_box).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            SuspendLayout();
            // 
            // Video_box
            // 
            Video_box.Location = new Point(403, 66);
            Video_box.Margin = new Padding(7, 8, 7, 8);
            Video_box.Name = "Video_box";
            Video_box.Size = new Size(988, 656);
            Video_box.SizeMode = PictureBoxSizeMode.Zoom;
            Video_box.TabIndex = 0;
            Video_box.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(Btn_Atras);
            panel2.Controls.Add(btn_minimizar);
            panel2.Controls.Add(btn_cerrar);
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1729, 55);
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
            // btn_minimizar
            // 
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1586, 0);
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
            btn_cerrar.Location = new Point(1661, 0);
            btn_cerrar.Margin = new Padding(2, 3, 2, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(78, 55);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // BtnCapturarFoto
            // 
            BtnCapturarFoto.BackColor = SystemColors.Highlight;
            BtnCapturarFoto.FlatStyle = FlatStyle.Flat;
            BtnCapturarFoto.Location = new Point(648, 738);
            BtnCapturarFoto.Margin = new Padding(7, 8, 7, 8);
            BtnCapturarFoto.Name = "BtnCapturarFoto";
            BtnCapturarFoto.Size = new Size(517, 63);
            BtnCapturarFoto.TabIndex = 1;
            BtnCapturarFoto.Text = "Capturar";
            BtnCapturarFoto.UseVisualStyleBackColor = false;
            BtnCapturarFoto.Click += BtnCapturarFoto_Click;
            // 
            // Foto_form
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1736, 1230);
            Controls.Add(panel2);
            Controls.Add(BtnCapturarFoto);
            Controls.Add(Video_box);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "Foto_form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Video_box).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Video_box;
        private Panel panel2;
        private PictureBox Btn_Atras;
        private PictureBox btn_minimizar;
        private PictureBox btn_cerrar;
        private Button BtnCapturarFoto;
        private PictureBox pictureBox1;
    }
}