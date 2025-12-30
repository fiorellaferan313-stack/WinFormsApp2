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
            button1 = new Button();
            btnRegistrar = new Button();
            label4 = new Label();
            txtPeso = new TextBox();
            label3 = new Label();
            cboSexo = new ComboBox();
            label2 = new Label();
            dtpNacimiento = new DateTimePicker();
            cboRaza = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblInfo = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PapayaWhip;
            groupBox1.Controls.Add(button1);
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
            groupBox1.Location = new Point(724, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 484);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRO DEL CONEJO";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(105, 424);
            button1.Name = "button1";
            button1.Size = new Size(357, 36);
            button1.TabIndex = 12;
            button1.Text = "[ Ver plan de crianza y nutrición ]";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Khaki;
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(162, 344);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(221, 62);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "REGISTRAR CONEJO";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 281);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 7;
            label4.Text = "Peso inicial (kg)";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(274, 281);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(250, 32);
            txtPeso.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 210);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 5;
            label3.Text = "Sexo";
            // 
            // cboSexo
            // 
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Macho", "Hembra" });
            cboSexo.Location = new Point(274, 202);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(250, 31);
            cboSexo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 141);
            label2.Name = "label2";
            label2.Size = new Size(220, 23);
            label2.TabIndex = 3;
            label2.Text = "Fecha de nacimiento";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(274, 132);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(250, 32);
            dtpNacimiento.TabIndex = 2;
            // 
            // cboRaza
            // 
            cboRaza.FormattingEnabled = true;
            cboRaza.Items.AddRange(new object[] { "Enano", "Holland Lop", "Mini Rex", "Neozelandés", "Californiano", "Angora", "Gigante de Flandes", "Blanca de Bouscat ", "Plateado de Champagne", "Ruso (Himalaya)" });
            cboRaza.Location = new Point(274, 62);
            cboRaza.Name = "cboRaza";
            cboRaza.Size = new Size(250, 31);
            cboRaza.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 62);
            label1.Name = "label1";
            label1.Size = new Size(59, 23);
            label1.TabIndex = 0;
            label1.Text = "Raza";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblInfo);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(724, 568);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(578, 221);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de Crianza y Nutrición";
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(79, 42);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(411, 176);
            lblInfo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._51ca41bc1535ed29ceda7be20bd2365f;
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(656, 790);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(692, 21);
            label5.Name = "label5";
            label5.Size = new Size(610, 40);
            label5.TabIndex = 10;
            label5.Text = "CONTROL DE CRIANZA Y NUTRICIÓN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.OldLace;
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_12_30_153718_removebg_preview;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormCrianzaNutricion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1448, 837);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCrianzaNutricion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCrianzaNutricion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pictureBox2;
        private Label label5;
        private GroupBox groupBox2;
        private Label lblInfo;
        private Button button1;
        private PictureBox pictureBox1;
    }
}