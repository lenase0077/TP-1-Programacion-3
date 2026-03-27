using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_Principal
{
    public partial class Ejercicio_3 : Form
    {
        FormularioPrincipal formularioPrincipal;
        public Ejercicio_3(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void Ejercicio_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioPrincipal.Show();
        }

        private void radioButtonCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSoltero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ejercicio_3_Load(object sender, EventArgs e)
        {
            var profesiones2 = new[]
            {
                "Data Entry",
                "Operador de PC",
                "Programador",
                "Reparador de PC",
                "Tester"
            };
            checkedListBoxProfesion.Items.AddRange(profesiones2);

            checkedListBoxProfesion.CheckOnClick = true; ///Permite seleccionar o deseleccionar un elemento con un solo clic

            //VALORES POR DEFECTO
            radioButtonF.Checked = true;
            radioButtonCasado.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarLabel();

        }

        private void actualizarLabel()
        {
            string sexo = "";
            string estadoCivil = "";
            string Oficio = "";


            foreach (RadioButton radioButton in GroupBoxSexo.Controls)
            {
                if (radioButton.Checked)
                {
                    sexo = radioButton.Text;
                    break;
                }
            }

            foreach (RadioButton radioButton in GroupBoxEstadoCivil.Controls)
            {
                if (radioButton.Checked)
                {
                    estadoCivil = radioButton.Text;
                    break;
                }
            }

            foreach (var item in checkedListBoxProfesion.CheckedItems)
            {
                Oficio += "\t - " + item.ToString() + "\n";
            }

            labelSeleccionado.Text = "Usted seleeciono los siguientes elementos: \n" +
                "Sexo: " + sexo + "\n" +
                "Estado Civil: " + estadoCivil + "\n" +
                "Oficio: \n" + Oficio;

            labelSeleccionado.Visible = true;
        }
    }
}
