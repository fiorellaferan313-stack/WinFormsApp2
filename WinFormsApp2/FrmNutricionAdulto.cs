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
    public partial class FrmNutricionAdulto : Form
    {
        public FrmNutricionAdulto()
        {
            InitializeComponent();
        }

        private void BtnRregresar_Click(object sender, EventArgs e)
        {
            FrmConejoAdulto frm = new FrmConejoAdulto();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
