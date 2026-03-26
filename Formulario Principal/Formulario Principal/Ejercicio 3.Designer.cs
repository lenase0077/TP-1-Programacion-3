namespace Formulario_Principal
{
    partial class Ejercicio_3
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
            GroupBoxSexo = new GroupBox();
            radioButtonM = new RadioButton();
            radioButtonF = new RadioButton();
            groupBox1 = new GroupBox();
            radioButtonSoltero = new RadioButton();
            radioButtonCasado = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            checkedListBoxProfesion = new CheckedListBox();
            GroupBoxSexo.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxSexo
            // 
            GroupBoxSexo.Controls.Add(radioButtonM);
            GroupBoxSexo.Controls.Add(radioButtonF);
            GroupBoxSexo.Location = new Point(80, 51);
            GroupBoxSexo.Name = "GroupBoxSexo";
            GroupBoxSexo.Size = new Size(150, 100);
            GroupBoxSexo.TabIndex = 0;
            GroupBoxSexo.TabStop = false;
            GroupBoxSexo.Text = "Sexo";
            // 
            // radioButtonM
            // 
            radioButtonM.AutoSize = true;
            radioButtonM.Location = new Point(18, 57);
            radioButtonM.Name = "radioButtonM";
            radioButtonM.Size = new Size(80, 19);
            radioButtonM.TabIndex = 1;
            radioButtonM.Text = "Masculino";
            radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            radioButtonF.AutoSize = true;
            radioButtonF.Location = new Point(18, 32);
            radioButtonF.Name = "radioButtonF";
            radioButtonF.Size = new Size(78, 19);
            radioButtonF.TabIndex = 0;
            radioButtonF.Text = "Femenino";
            radioButtonF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonSoltero);
            groupBox1.Controls.Add(radioButtonCasado);
            groupBox1.Location = new Point(361, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado Civil";
            // 
            // radioButtonSoltero
            // 
            radioButtonSoltero.AutoSize = true;
            radioButtonSoltero.Location = new Point(16, 57);
            radioButtonSoltero.Name = "radioButtonSoltero";
            radioButtonSoltero.Size = new Size(62, 19);
            radioButtonSoltero.TabIndex = 3;
            radioButtonSoltero.Text = "Soltero";
            radioButtonSoltero.UseVisualStyleBackColor = true;
            radioButtonSoltero.CheckedChanged += radioButtonSoltero_CheckedChanged;
            // 
            // radioButtonCasado
            // 
            radioButtonCasado.AutoSize = true;
            radioButtonCasado.Location = new Point(16, 32);
            radioButtonCasado.Name = "radioButtonCasado";
            radioButtonCasado.Size = new Size(64, 19);
            radioButtonCasado.TabIndex = 2;
            radioButtonCasado.Text = "Casado";
            radioButtonCasado.UseVisualStyleBackColor = true;
            radioButtonCasado.CheckedChanged += radioButtonCasado_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(186, 335);
            button1.Name = "button1";
            button1.Size = new Size(200, 30);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxProfesion
            // 
            checkedListBoxProfesion.FormattingEnabled = true;
            checkedListBoxProfesion.Location = new Point(186, 200);
            checkedListBoxProfesion.Name = "checkedListBoxProfesion";
            checkedListBoxProfesion.Size = new Size(200, 94);
            checkedListBoxProfesion.TabIndex = 3;
            // 
            // Ejercicio_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 661);
            Controls.Add(checkedListBoxProfesion);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxSexo);
            Name = "Ejercicio_3";
            Text = "Ejercicio_3";
            FormClosed += Ejercicio_3_FormClosed;
            Load += Ejercicio_3_Load;
            GroupBoxSexo.ResumeLayout(false);
            GroupBoxSexo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxSexo;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private CheckedListBox checkedListBoxProfesion;
        private RadioButton radioButtonM;
        private RadioButton radioButtonF;
        private RadioButton radioButtonSoltero;
        private RadioButton radioButtonCasado;
    }
}