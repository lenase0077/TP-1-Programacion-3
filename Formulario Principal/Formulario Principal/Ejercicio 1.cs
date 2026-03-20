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

        private void ValidarQueNoHayNombreRepetido(ListBox listBox, string mensaje)
        {
            foreach (var item in listBox.Items)
            {
                if (item.ToString().ToLower().Trim() == textBoxIngresoNombre.Text.ToLower().Trim())
                {
                    MessageBox.Show(mensaje);
                    textBoxIngresoNombre.Clear();
                    return;
                }
            }
        }

        private void buttonAgregarNombre_Click(object sender, EventArgs e)
        {
            if (textBoxIngresoNombre.Text.IsWhiteSpace())
            {
                textBoxIngresoNombre.Clear();
                MessageBox.Show("Ingrese un nombre para agregar a la lista");
                return;
            }

            ValidarQueNoHayNombreRepetido(listBoxNombres1, "No se puede ingresar nombres repetidos de la lista 1");

            ValidarQueNoHayNombreRepetido(listBoxSalida1, "No se puede ingresar nombres repetidos de la lista 2");

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
