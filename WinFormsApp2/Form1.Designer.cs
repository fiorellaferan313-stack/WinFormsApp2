namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            TxtUsuario = new TextBox();
            TxtContrasena = new TextBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            BtnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._931c5cea6ad27e362cece6cdfcbd2b77;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 752);
            panel1.TabIndex = 0;
            // 
            // TxtUsuario
            // 
            TxtUsuario.BorderStyle = BorderStyle.None;
            TxtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsuario.Location = new Point(671, 338);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(269, 25);
            TxtUsuario.TabIndex = 1;
            TxtUsuario.TextChanged += TxtUsuario_TextChanged;
            // 
            // TxtContrasena
            // 
            TxtContrasena.BorderStyle = BorderStyle.None;
            TxtContrasena.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtContrasena.Location = new Point(671, 433);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.Size = new Size(269, 25);
            TxtContrasena.TabIndex = 2;
            TxtContrasena.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_12_16_215601;
            pictureBox1.Location = new Point(671, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(671, 464);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Recordar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Pink;
            BtnLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.Location = new Point(737, 526);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(235, 116);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "INICIAR SESIÓN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(671, 285);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 6;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(671, 391);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 7;
            label2.Text = "CONTRASEÑA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1149, 750);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(TxtContrasena);
            Controls.Add(TxtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox TxtUsuario;
        private TextBox TxtContrasena;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Button BtnLogin;
        private Label label1;
        private Label label2;
    }
}
