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
            buttonEjercicio2 = new Button();
            buttonEjercicio3 = new Button();
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
            // buttonEjercicio2
            // 
            buttonEjercicio2.FlatStyle = FlatStyle.Flat;
            buttonEjercicio2.Font = new Font("Segoe UI" ,15F);
            buttonEjercicio2.Location = new Point(301 ,60);
            buttonEjercicio2.Name = "buttonEjercicio2";
            buttonEjercicio2.Size = new Size(186 ,62);
            buttonEjercicio2.TabIndex = 1;
            buttonEjercicio2.Text = "EJERCICIO 2";
            buttonEjercicio2.UseVisualStyleBackColor = true;
            buttonEjercicio2.Click +=  buttonEjercicio2_Click ;
            // 
            // buttonEjercicio3
            // 
            buttonEjercicio3.FlatStyle = FlatStyle.Flat;
            buttonEjercicio3.Font = new Font("Segoe UI" ,15F);
            buttonEjercicio3.Location = new Point(516 ,60);
            buttonEjercicio3.Name = "buttonEjercicio3";
            buttonEjercicio3.Size = new Size(186 ,62);
            buttonEjercicio3.TabIndex = 2;
            buttonEjercicio3.Text = "EJERCICIO 3";
            buttonEjercicio3.UseVisualStyleBackColor = true;
            buttonEjercicio3.MouseClick +=  buttonEjercicio3_MouseClick ;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F ,15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800 ,450);
            Controls.Add(buttonEjercicio3);
            Controls.Add(buttonEjercicio2);
            Controls.Add(btnEjercicio_1);
            Name = "FormularioPrincipal";
            Text = "Formulario Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEjercicio_1;
        private Button buttonEjercicio2;
        private Button buttonEjercicio3;
    }
}
