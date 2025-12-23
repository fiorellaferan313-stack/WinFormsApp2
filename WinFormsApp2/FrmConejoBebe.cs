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
    public partial class FrmConejoBebe : Form
    {
        public FrmConejoBebe()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
           
            FrmCrianzaNutricion frm = new FrmCrianzaNutricion();
            frm.Show();
            this.Hide();
        }

        private void BtnNutricion_Click(object sender, EventArgs e)
        {
              
            FrmNutricionBebe frm = new FrmNutricionBebe();
            frm.Show();
            this.Hide();

        }
    }
}
