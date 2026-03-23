using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_Principal
{
    public partial class Ejercicio_2 : Form
    {
        FormularioPrincipal formularioPrincipal;

        public Ejercicio_2(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        public Ejercicio_2()
        {
            InitializeComponent();
        }


        private void Ejercicio_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioPrincipal.Show();
        }
    }
}
