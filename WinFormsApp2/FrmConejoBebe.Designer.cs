namespace WinFormsApp2
{
    partial class FrmConejoBebe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConejoBebe));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            BtnNutricion = new Button();
            BtnRegresar = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_20_dic_2025__07_20_06_p_m_;
            pictureBox1.Location = new Point(434, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 294);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 285);
            label1.Name = "label1";
            label1.Size = new Size(813, 21);
            label1.TabIndex = 1;
            label1.Text = "EN ESTA ETAPA SE EXPLICA EL CUIDADO BÁSICO DEL CONEJO BEBÉ DESDE SU NACIMIENTO";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 324);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(334, 240);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Captura_de_pantalla_2025_12_20_202622;
            pictureBox3.Location = new Point(434, 446);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(334, 240);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.Captura_de_pantalla_2025_12_20_202637;
            pictureBox4.Location = new Point(819, 339);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(334, 225);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // BtnNutricion
            // 
            BtnNutricion.BackColor = Color.PeachPuff;
            BtnNutricion.Location = new Point(990, 680);
            BtnNutricion.Name = "BtnNutricion";
            BtnNutricion.Size = new Size(193, 64);
            BtnNutricion.TabIndex = 6;
            BtnNutricion.Text = "NUTRICIÓN";
            BtnNutricion.UseVisualStyleBackColor = false;
            BtnNutricion.Click += BtnNutricion_Click;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Location = new Point(12, 13);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(157, 29);
            BtnRegresar.TabIndex = 7;
            BtnRegresar.Text = "REGRESAR";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.Captura_de_pantalla_2025_12_18_1942421;
            pictureBox5.Location = new Point(185, 48);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(215, 208);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.Captura_de_pantalla_2025_12_18_1942421;
            pictureBox6.Location = new Point(907, 48);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(215, 208);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // FrmConejoBebe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._43534557c3f3dc719095a0eef9b4d1421;
            ClientSize = new Size(1216, 774);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(BtnRegresar);
            Controls.Add(BtnNutricion);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConejoBebe";
            Text = "FrmConejoBebe";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button BtnNutricion;
        private Button BtnRegresar;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}