using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FrmCrianzaNutricion : Form
    {
        public FrmCrianzaNutricion()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmConejoAdulto frm = new FrmConejoAdulto();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmConejoBebe frm = new FrmConejoBebe();
            frm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmConejoJoven frm = new FrmConejoJoven();
            frm.Show();
            this.Hide();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLaberinto frm = new FrmLaberinto();
            frm.Show();
            this.Hide();
        }
    }
}
