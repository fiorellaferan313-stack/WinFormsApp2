using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormCrianzaNutricion : Form
    {
        // VARIABLES DE CLASE (COMPARTIDAS ENTRE BOTONES)
        int edadMeses;
        string etapa;
        string nutricion;

        public FormCrianzaNutricion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboRaza.SelectedIndex == -1 ||
                cboSexo.SelectedIndex == -1 ||
                txtPeso.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            double peso;
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Ingrese un peso válido");
                return;
            }

            // DATOS
            string raza = cboRaza.SelectedItem.ToString();
            string sexo = cboSexo.SelectedItem.ToString();
            DateTime fechaNacimiento = dtpNacimiento.Value;

            // CALCULAR EDAD EN MESES
            DateTime hoy = DateTime.Today;
            edadMeses = (hoy.Year - fechaNacimiento.Year) * 12 + (hoy.Month - fechaNacimiento.Month);

            if (fechaNacimiento.Day > hoy.Day)
                edadMeses--;

            // DETERMINAR ETAPA
            if (edadMeses <= 2)
                etapa = "Bebé";
            else if (edadMeses <= 6)
                etapa = "Joven";
            else
                etapa = "Adulto";

            // DETERMINAR NUTRICIÓN
            if (etapa == "Bebé")
                nutricion = "Leche materna y concentrado inicial";
            else if (etapa == "Joven")
                nutricion = "Dieta balanceada para crecimiento";
            else
                nutricion = "Dieta de mantenimiento";

            // MOSTRAR RESUMEN EN EL LABEL
            lblInfo.Text =
                "Raza: " + raza +
                "\nSexo: " + sexo +
                "\nEdad: " + edadMeses + " meses" +
                "\nEtapa: " + etapa +
                "\n\nCrianza: Control reproductivo" +
                "\nNutrición: " + nutricion;
        }

        // BOTÓN VER PLAN (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            FormPlanNutricion plan = new FormPlanNutricion(
                cboRaza.SelectedItem.ToString(),
                cboSexo.SelectedItem.ToString(),
                edadMeses,
                etapa,
                nutricion
            );

            plan.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}



