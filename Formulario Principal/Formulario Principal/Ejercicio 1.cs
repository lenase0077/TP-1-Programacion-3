using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
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

            // 1. Chequear si es white space
            if (textBoxIngresoNombre.Text.IsWhiteSpace())
            {
                // Funcion para validar que no halla nombres repetidos
                foreach (var item in listBoxNombres1.Items)
                {
                    if (item.ToString().ToLower().Trim() == textBoxIngresoNombre.Text.ToLower().Trim())
                    {
                        MessageBox.Show("No se puede ingresar nombres repetidos de la lista 1");
                        textBoxIngresoNombre.Clear();
                        return;
                    }
                }
                
                //Repito el prosceso con la lista 2
                foreach (var item in listBoxSalida1.Items)
                {
                    if (item.ToString().ToLower().Trim() == textBoxIngresoNombre.Text.ToLower().Trim())
                    {
                        MessageBox.Show("No se puede ingresar nombres repetidos de la lista 2");
                        textBoxIngresoNombre.Clear();
                        return;
                    }
                }

                listBoxNombres1.Items.Add(textBoxIngresoNombre.Text.Trim());
            }

            // 2. Chequear si ya está en la lista
            foreach (var item in listBoxNombres1.Items)
            {
                if (item.ToString().ToLower().Trim() == textBoxIngresoNombre.Text.ToLower().Trim())
                {
                    MessageBox.Show("No se puede ingresar nombres repetidos");
                    textBoxIngresoNombre.Clear();
                    return;
                }
            }

            listBoxNombres1.Items.Add(textBoxIngresoNombre.Text.Trim());

            textBoxIngresoNombre.Clear();
        }

        private void buttonPasarUnItem_Click(object sender, EventArgs e)
        {
            if (!listBoxNombres1.Text.IsWhiteSpace())
            {
                listBoxSalida1.Items.Add(listBoxNombres1.Text);
                listBoxNombres1.Items.Remove(listBoxNombres1.Text);
            }

            else
            {
                MessageBox.Show("Seleccione un nombre de la lista");
            }
        }

        private void textBoxIngresoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                buttonAgregarNombre.PerformClick();
            }
        }

        private void buttonPasarMultipleItem_Click(object sender, EventArgs e)
        {
            if (listBoxNombres1.Items.Count == 0) //me parecio buena idea ya que le da un estimulo al usuario de que el boton si funciona.
            { 
                MessageBox.Show("No hay nombres para pasar");
                return;
            }
            listBoxSalida1.Items.AddRange(listBoxNombres1.Items); // Paso todos los items de listBoxNombres1 a listBoxSalida1 pasando directamente el contenido
            listBoxNombres1.Items.Clear(); 
        }
    }
}
