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
            //if (textBoxIngresoNombre.Text.Trim().Length > 0) <- - Otra forma de validar que el texto no esté vacío
            //Con el método Trim() se eliminan los espacios en blanco al inicio y al final del texto, por lo que si el usuario ingresa solo espacios, el resultado será una cadena vacía (""). Por lo tanto, al verificar si el resultado de Trim() es diferente de una cadena vacía, se asegura que el usuario haya ingresado un nombre válido.
            if (textBoxIngresoNombre.Text.Trim() != "")
            {
                listBoxNombres1.Items.Add(textBoxIngresoNombre.Text.Trim());
            }

            else
            {
                MessageBox.Show("Ingrese un nombre para agregar a la lista");
            }

            //Hacemos esto para que el cuadro de texto quede vacío después de agregar el nombre a la lista, para que el usuario pueda ingresar un nuevo nombre sin tener que borrar el anterior manualmente.
            textBoxIngresoNombre.Text = "";
        }
    }
}
