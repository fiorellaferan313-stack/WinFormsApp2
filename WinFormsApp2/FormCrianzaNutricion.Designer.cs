namespace WinFormsApp2
{
    partial class FormCrianzaNutricion
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            cboRaza = new ComboBox();
            dtpNacimiento = new DateTimePicker();
            label2 = new Label();
            cboSexo = new ComboBox();
            label3 = new Label();
            txtPeso = new TextBox();
            label4 = new Label();
            btnRegistrar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PapayaWhip;
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPeso);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboSexo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpNacimiento);
            groupBox1.Controls.Add(cboRaza);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(547, 553);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRO DEL CONEJO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 100);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "Raza";
            // 
            // cboRaza
            // 
            cboRaza.FormattingEnabled = true;
            cboRaza.Items.AddRange(new object[] { "Enano", "Holland Lop", "Mini Rex", "Neozelandés", "Californiano", "Angora", "Gigante de Flandes", "Blanca de Bouscat ", "Plateado de Champagne", "Ruso (Himalaya)" });
            cboRaza.Location = new Point(287, 92);
            cboRaza.Name = "cboRaza";
            cboRaza.Size = new Size(151, 31);
            cboRaza.TabIndex = 1;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(287, 166);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(250, 32);
            dtpNacimiento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 175);
            label2.Name = "label2";
            label2.Size = new Size(220, 23);
            label2.TabIndex = 3;
            label2.Text = "Fecha de nacimiento";
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Macho", "Hembra" });
            cboSexo.Location = new Point(287, 252);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(151, 31);
            cboSexo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 260);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 5;
            label3.Text = "Sexo";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(287, 330);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 32);
            txtPeso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 330);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 7;
            label4.Text = "Peso inicial (kg)";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(167, 447);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(221, 62);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "REGISTRAR CONEJO";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.conejo_sin_fondo;
            pictureBox1.Location = new Point(662, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._51ca41bc1535ed29ceda7be20bd2365f;
            pictureBox2.Location = new Point(768, 434);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(296, 293);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // FormCrianzaNutricion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 790);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrianzaNutricion";
            Text = "FormCrianzaNutricion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cboRaza;
        private Label label1;
        private ComboBox cboSexo;
        private Label label2;
        private DateTimePicker dtpNacimiento;
        private Label label3;
        private Button btnRegistrar;
        private Label label4;
        private TextBox txtPeso;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}