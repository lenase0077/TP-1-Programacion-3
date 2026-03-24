namespace Formulario_Principal
{
    partial class Ejercicio_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxIngresoDeDatos = new GroupBox();
            buttonAgregar = new Button();
            labelApellido = new Label();
            labelNombre = new Label();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            groupBoxElementos = new GroupBox();
            buttonBorrar = new Button();
            listBoxElementos = new ListBox();
            groupBoxIngresoDeDatos.SuspendLayout();
            groupBoxElementos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxIngresoDeDatos
            // 
            groupBoxIngresoDeDatos.Controls.Add(buttonAgregar);
            groupBoxIngresoDeDatos.Controls.Add(labelApellido);
            groupBoxIngresoDeDatos.Controls.Add(labelNombre);
            groupBoxIngresoDeDatos.Controls.Add(textBoxApellido);
            groupBoxIngresoDeDatos.Controls.Add(textBoxNombre);
            groupBoxIngresoDeDatos.Location = new Point(24, 31);
            groupBoxIngresoDeDatos.Name = "groupBoxIngresoDeDatos";
            groupBoxIngresoDeDatos.Size = new Size(295, 407);
            groupBoxIngresoDeDatos.TabIndex = 0;
            groupBoxIngresoDeDatos.TabStop = false;
            groupBoxIngresoDeDatos.Text = "Ingreso de Datos";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Font = new Font("Segoe UI", 11.25F);
            buttonAgregar.Location = new Point(71, 253);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(142, 46);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelApellido.Location = new Point(15, 195);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(71, 20);
            labelApellido.TabIndex = 3;
            labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            labelNombre.Location = new Point(15, 151);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(71, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre:";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(107, 192);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(168, 23);
            textBoxApellido.TabIndex = 1;
            textBoxApellido.KeyPress += textBoxApellido_KeyPress;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(107, 148);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(168, 23);
            textBoxNombre.TabIndex = 0;
            textBoxNombre.KeyPress += textBoxNombre_KeyPress;
            // 
            // groupBoxElementos
            // 
            groupBoxElementos.Controls.Add(buttonBorrar);
            groupBoxElementos.Controls.Add(listBoxElementos);
            groupBoxElementos.Location = new Point(336, 31);
            groupBoxElementos.Name = "groupBoxElementos";
            groupBoxElementos.Size = new Size(295, 407);
            groupBoxElementos.TabIndex = 1;
            groupBoxElementos.TabStop = false;
            groupBoxElementos.Text = "Elementos";
            // 
            // buttonBorrar
            // 
            buttonBorrar.Font = new Font("Segoe UI", 11.25F);
            buttonBorrar.Location = new Point(79, 342);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(142, 46);
            buttonBorrar.TabIndex = 1;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // listBoxElementos
            // 
            listBoxElementos.FormattingEnabled = true;
            listBoxElementos.Location = new Point(18, 33);
            listBoxElementos.Name = "listBoxElementos";
            listBoxElementos.Size = new Size(259, 289);
            listBoxElementos.Sorted = true;
            listBoxElementos.TabIndex = 0;
            // 
            // Ejercicio_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxElementos);
            Controls.Add(groupBoxIngresoDeDatos);
            Name = "Ejercicio_2";
            Text = "Ejercicio_2";
            FormClosed += Ejercicio_2_FormClosed;
            groupBoxIngresoDeDatos.ResumeLayout(false);
            groupBoxIngresoDeDatos.PerformLayout();
            groupBoxElementos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxIngresoDeDatos;
        private Label labelApellido;
        private Label labelNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private GroupBox groupBoxElementos;
        private Button buttonAgregar;
        private Button buttonBorrar;
        private ListBox listBoxElementos;
    }
}