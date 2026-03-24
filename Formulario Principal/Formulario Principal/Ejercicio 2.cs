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

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            if (textBoxNombre.Text.IsWhiteSpace() || textBoxApellido.Text.IsWhiteSpace())
            {
                MessageBox.Show("Ingrese un nombre y apellido para agregar a la lista");
                return;
            }

            foreach (String item in listBoxElementos.Items)
            {
                String nombre = textBoxNombre.Text + textBoxApellido.Text;

                // String.Replace() reemplaza todas las instancias de un string por otro.
                // En este caso, reemplzar por string.Empty elimina a los espacios vacíos.
                if (nombre.Replace(" ", string.Empty).ToLower() == item.Replace(" ", string.Empty).ToLower())
                {
                    MessageBox.Show("El nombre ya se encuentra en la lista.");
                    return;
                }
            }


            listBoxElementos.Items.Add(textBoxNombre.Text.Trim() + " " + textBoxApellido.Text.Trim());
            textBoxNombre.Clear();
            textBoxApellido.Clear();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (listBoxElementos.Items.Count == 0)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            if (listBoxElementos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento para eliminar de la lista");
                return;
            }

            listBoxElementos.Items.RemoveAt(listBoxElementos.SelectedIndex);
            MessageBox.Show("Elemento eliminado de la lista");

        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                textBoxApellido.Focus();
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                buttonAgregar.PerformClick();
                textBoxNombre.Focus();
            }
        }
    }
}
