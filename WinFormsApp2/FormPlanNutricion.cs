using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormPlanNutricion : Form
    {
        public FormPlanNutricion(
            string raza,
            string sexo,
            int edadMeses,
            string etapa,
            string nutricion)
        {
            InitializeComponent();

            lblDatosConejo.Text =
                "Raza: " + raza +
                "\nSexo: " + sexo +
                "\nEdad: " + edadMeses + " meses" +
                "\nEtapa: " + etapa;

            clbCrianza.Items.Clear();
            clbCrianza.Items.Add("Control reproductivo");
            clbCrianza.Items.Add("Higiene del alojamiento");
            clbCrianza.Items.Add("Separación por etapa");

            clbNutricion.Items.Clear();

            if (etapa == "Bebé")
            {
                clbNutricion.Items.Add("Leche materna");
                clbNutricion.Items.Add("Concentrado inicial");
            }
            else if (etapa == "Joven")
            {
                clbNutricion.Items.Add("Concentrado de crecimiento");
                clbNutricion.Items.Add("Forraje fresco");
            }
            else
            {
                clbNutricion.Items.Add("Dieta de mantenimiento");
                clbNutricion.Items.Add("Agua limpia permanente");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCrianzaNutricion frm = new FormCrianzaNutricion();
            frm.Show();
            this.Hide();
        }
    }
}

