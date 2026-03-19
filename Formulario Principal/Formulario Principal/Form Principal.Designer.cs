namespace Formulario_Principal
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEjercicio_1 = new Button();
            SuspendLayout();
            // 
            // btnEjercicio_1
            // 
            btnEjercicio_1.FlatStyle = FlatStyle.Flat;
            btnEjercicio_1.Font = new Font("Segoe UI" ,15F);
            btnEjercicio_1.Location = new Point(89 ,60);
            btnEjercicio_1.Name = "btnEjercicio_1";
            btnEjercicio_1.Size = new Size(186 ,62);
            btnEjercicio_1.TabIndex = 0;
            btnEjercicio_1.Text = "EJERCICIO 1";
            btnEjercicio_1.UseVisualStyleBackColor = true;
            btnEjercicio_1.Click +=  btnEjercicio_1_Click ;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F ,15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800 ,450);
            Controls.Add(btnEjercicio_1);
            Name = "FormularioPrincipal";
            Text = "Formulario Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEjercicio_1;
    }
}
