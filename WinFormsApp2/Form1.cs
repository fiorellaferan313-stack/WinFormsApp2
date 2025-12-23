using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Admin" && TxtContrasena.Text == "1234")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
                MessageBox.Show("Se inició sesión con éxito");
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}





