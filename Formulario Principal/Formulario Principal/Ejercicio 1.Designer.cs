namespace Formulario_Principal
{
    partial class Ejercicio_1
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
            textBoxIngresoNombre = new TextBox();
            buttonAgregar = new Button();
            listBoxNombres1 = new ListBox();
            SuspendLayout();
            // 
            // textBoxIngresoNombre
            // 
            textBoxIngresoNombre.Location = new Point(253, 34);
            textBoxIngresoNombre.Name = "textBoxIngresoNombre";
            textBoxIngresoNombre.Size = new Size(284, 23);
            textBoxIngresoNombre.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(556, 34);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(75, 23);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "button1";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // listBoxNombres1
            // 
            listBoxNombres1.FormattingEnabled = true;
            listBoxNombres1.Location = new Point(27, 102);
            listBoxNombres1.Name = "listBoxNombres1";
            listBoxNombres1.Size = new Size(207, 304);
            listBoxNombres1.TabIndex = 2;
            // 
            // Ejercicio_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxNombres1);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxIngresoNombre);
            Name = "Ejercicio_1";
            Text = "Ejercicio_1";
            FormClosed += Ejercicio_1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIngresoNombre;
        private Button buttonAgregar;
        private ListBox listBoxNombres1;
    }
}