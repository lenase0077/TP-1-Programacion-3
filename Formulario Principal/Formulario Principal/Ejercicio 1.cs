using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_Principal
{
    public partial class Ejercicio_1 : Form
    {
        FormularioPrincipal formularioPrincipal;
        public Ejercicio_1(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void Ejercicio_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioPrincipal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxNombres1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarNombre_Click(object sender, EventArgs e)
        {
            //listBoxNombres1
            //textBoxIngresoNombre

            if (!string.IsNullOrEmpty(textBoxIngresoNombre.Text))
            {
                // funcion if para validar que no haya caracteres vacios
                if (string.IsNullOrWhiteSpace(textBoxIngresoNombre.Text))
                {
                    MessageBox.Show("No se puede ingresar caracteres vacios");
                    textBoxIngresoNombre.Clear();
                    return;
                }


                listBoxNombres1.Items.Add(textBoxIngresoNombre.Text);
                textBoxIngresoNombre.Clear();
            }
        }
    }
}
