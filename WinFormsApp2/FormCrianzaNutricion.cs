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
    public partial class FormCrianzaNutricion : Form
    {
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

            // 2. Obtener datos del formulario
            string raza = cboRaza.SelectedItem.ToString();
            string sexo = cboSexo.SelectedItem.ToString();
            DateTime fechaNacimiento = dtpNacimiento.Value;

            // 3. CALCULAR edad en meses (AQUÍ SE CREA)
            DateTime hoy = DateTime.Today;
            int edadMeses = (hoy.Year - fechaNacimiento.Year) * 12 + (hoy.Month - fechaNacimiento.Month);

            if (fechaNacimiento.Day > hoy.Day)
                edadMeses--;

            // 4. Determinar etapa
            string etapa;

            if (edadMeses <= 2)
                etapa = "Bebé";
            else if (edadMeses <= 6)
                etapa = "Joven";
            else
                etapa = "Adulto";

            // 5. Mostrar para comprobar (TEMPORAL)
            MessageBox.Show(
                "Raza: " + raza +
                "\nSexo: " + sexo +
                "\nEdad: " + edadMeses + " meses" +
                "\nEtapa: " + etapa);
        }
    }
}
