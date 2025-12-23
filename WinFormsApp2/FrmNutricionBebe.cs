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
    public partial class FrmNutricionBebe : Form
    {
        public FrmNutricionBebe()
        {
            InitializeComponent();
        }

        private void BtnRregresar_Click(object sender, EventArgs e)
        {
            FrmConejoBebe frm = new FrmConejoBebe();
            frm.Show();
            this.Hide();
        }
    }
}
