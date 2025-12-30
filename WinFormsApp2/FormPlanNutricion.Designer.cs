namespace WinFormsApp2
{
    partial class FormPlanNutricion
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
            lblTitulo = new Label();
            gbDatosConejo = new GroupBox();
            lblDatosConejo = new Label();
            gbCrianza = new GroupBox();
            clbCrianza = new CheckedListBox();
            gbNutricion = new GroupBox();
            clbNutricion = new CheckedListBox();
            pictureBox1 = new PictureBox();
            gbDatosConejo.SuspendLayout();
            gbCrianza.SuspendLayout();
            gbNutricion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(449, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(535, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PLAN DE CRIANZA Y NUTRICIÓN";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbDatosConejo
            // 
            gbDatosConejo.Controls.Add(lblDatosConejo);
            gbDatosConejo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDatosConejo.Location = new Point(506, 78);
            gbDatosConejo.Name = "gbDatosConejo";
            gbDatosConejo.Size = new Size(421, 454);
            gbDatosConejo.TabIndex = 1;
            gbDatosConejo.TabStop = false;
            gbDatosConejo.Text = "DATOS DEL CONEJO";
            // 
            // lblDatosConejo
            // 
            lblDatosConejo.BorderStyle = BorderStyle.FixedSingle;
            lblDatosConejo.Location = new Point(6, 42);
            lblDatosConejo.Name = "lblDatosConejo";
            lblDatosConejo.Size = new Size(395, 365);
            lblDatosConejo.TabIndex = 0;
            // 
            // gbCrianza
            // 
            gbCrianza.Controls.Add(clbCrianza);
            gbCrianza.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCrianza.Location = new Point(46, 218);
            gbCrianza.Name = "gbCrianza";
            gbCrianza.Size = new Size(403, 383);
            gbCrianza.TabIndex = 1;
            gbCrianza.TabStop = false;
            gbCrianza.Text = "RECOMENDACIONES DE CRIANZA";
            // 
            // clbCrianza
            // 
            clbCrianza.FormattingEnabled = true;
            clbCrianza.Location = new Point(15, 40);
            clbCrianza.Name = "clbCrianza";
            clbCrianza.Size = new Size(382, 328);
            clbCrianza.TabIndex = 0;
            // 
            // gbNutricion
            // 
            gbNutricion.Controls.Add(clbNutricion);
            gbNutricion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbNutricion.Location = new Point(964, 218);
            gbNutricion.Name = "gbNutricion";
            gbNutricion.Size = new Size(410, 377);
            gbNutricion.TabIndex = 1;
            gbNutricion.TabStop = false;
            gbNutricion.Text = "PLAN DE NUTRICIÓN";
            // 
            // clbNutricion
            // 
            clbNutricion.FormattingEnabled = true;
            clbNutricion.Location = new Point(22, 45);
            clbNutricion.Name = "clbNutricion";
            clbNutricion.Size = new Size(382, 328);
            clbNutricion.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_12_30_153718_removebg_preview;
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormPlanNutricion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1430, 790);
            Controls.Add(pictureBox1);
            Controls.Add(gbNutricion);
            Controls.Add(gbCrianza);
            Controls.Add(gbDatosConejo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPlanNutricion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPlanCrianzaNutricion";
            gbDatosConejo.ResumeLayout(false);
            gbCrianza.ResumeLayout(false);
            gbNutricion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gbDatosConejo;
        private Label lblDatosConejo;
        private GroupBox gbCrianza;
        private CheckedListBox clbCrianza;
        private GroupBox gbNutricion;
        private CheckedListBox clbNutricion;
        private PictureBox pictureBox1;
    }
}