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

        private void Ejercicio_1_FormClosed(object sender ,FormClosedEventArgs e)
        {
            formularioPrincipal.Show();
        }
    }
}
