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
    public partial class FrmLaberinto : Form
    {


        public FrmLaberinto()
        {
            InitializeComponent();
            MoveToBeginning();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

            MoveToBeginning();

        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("GANASTE !");
            MoveToBeginning();


        }

        private void MoveToBeginning()
        {
            Point StartPoint = new Point(30, 30);
            Cursor.Position = PointToScreen(StartPoint);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmCrianzaNutricion frm = new FrmCrianzaNutricion();
            frm.Show();
            this.Hide();
        }
    }
}
