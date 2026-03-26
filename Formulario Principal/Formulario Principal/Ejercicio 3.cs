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
    }
}
