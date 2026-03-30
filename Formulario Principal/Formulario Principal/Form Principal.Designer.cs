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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnEjercicio_1
            // 
            btnEjercicio_1.FlatStyle = FlatStyle.Flat;
            btnEjercicio_1.Font = new Font("Segoe UI", 15F);
            btnEjercicio_1.Location = new Point(89, 60);
            btnEjercicio_1.Name = "btnEjercicio_1";
            btnEjercicio_1.Size = new Size(186, 62);
            btnEjercicio_1.TabIndex = 0;
            btnEjercicio_1.Text = "EJERCICIO 1";
            btnEjercicio_1.UseVisualStyleBackColor = true;
            btnEjercicio_1.Click += btnEjercicio_1_Click;
            // 
            // buttonEjercicio2
            // 
            buttonEjercicio2.FlatStyle = FlatStyle.Flat;
            buttonEjercicio2.Font = new Font("Segoe UI", 15F);
            buttonEjercicio2.Location = new Point(301, 60);
            buttonEjercicio2.Name = "buttonEjercicio2";
            buttonEjercicio2.Size = new Size(186, 62);
            buttonEjercicio2.TabIndex = 1;
            buttonEjercicio2.Text = "EJERCICIO 2";
            buttonEjercicio2.UseVisualStyleBackColor = true;
            buttonEjercicio2.Click += buttonEjercicio2_Click;
            // 
            // buttonEjercicio3
            // 
            buttonEjercicio3.FlatStyle = FlatStyle.Flat;
            buttonEjercicio3.Font = new Font("Segoe UI", 15F);
            buttonEjercicio3.Location = new Point(516, 60);
            buttonEjercicio3.Name = "buttonEjercicio3";
            buttonEjercicio3.Size = new Size(186, 62);
            buttonEjercicio3.TabIndex = 2;
            buttonEjercicio3.Text = "EJERCICIO 3";
            buttonEjercicio3.UseVisualStyleBackColor = true;
            buttonEjercicio3.MouseClick += buttonEjercicio3_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 184);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 3;
            label1.Text = "Integrantes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(216, 207);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 5;
            label2.Text = "Agustín Leandro Vallejos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(217, 239);
            label3.Name = "label3";
            label3.Size = new Size(207, 25);
            label3.TabIndex = 6;
            label3.Text = "Alejo Martinez Olmedo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(217, 267);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 7;
            label4.Text = "Ivan Lupani";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(217, 294);
            label5.Name = "label5";
            label5.Size = new Size(296, 25);
            label5.TabIndex = 8;
            label5.Text = "Leandro Nahuel Serran Salomone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(217, 322);
            label6.Name = "label6";
            label6.Size = new Size(166, 25);
            label6.TabIndex = 9;
            label6.Text = "Pablo Daniel Raho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(217, 354);
            label7.Name = "label7";
            label7.Size = new Size(242, 25);
            label7.TabIndex = 10;
            label7.Text = "Sebastian Andres Durazzini";
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEjercicio3);
            Controls.Add(buttonEjercicio2);
            Controls.Add(btnEjercicio_1);
            Name = "FormularioPrincipal";
            Text = "Formulario Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjercicio_1;
        private Button buttonEjercicio2;
        private Button buttonEjercicio3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
