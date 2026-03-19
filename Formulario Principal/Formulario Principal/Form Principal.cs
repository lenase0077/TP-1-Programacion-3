namespace Formulario_Principal
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio_1_Click(object sender ,EventArgs e)
        {
            Ejercicio_1 ejercicio_1 = new Ejercicio_1(this);
            ejercicio_1.Show();
            this.Hide();
        }
    }
}
