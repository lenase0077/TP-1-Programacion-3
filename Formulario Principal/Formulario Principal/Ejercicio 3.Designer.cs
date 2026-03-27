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
            GroupBoxEstadoCivil = new GroupBox();
            radioButtonSoltero = new RadioButton();
            radioButtonCasado = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            botonSeleccionado = new Button();
            checkedListBoxProfesion = new CheckedListBox();
            labelSeleccionado = new Label();
            GroupBoxSexo.SuspendLayout();
            GroupBoxEstadoCivil.SuspendLayout();
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
            // GroupBoxEstadoCivil
            // 
            GroupBoxEstadoCivil.Controls.Add(radioButtonSoltero);
            GroupBoxEstadoCivil.Controls.Add(radioButtonCasado);
            GroupBoxEstadoCivil.Location = new Point(361, 51);
            GroupBoxEstadoCivil.Name = "GroupBoxEstadoCivil";
            GroupBoxEstadoCivil.Size = new Size(150, 100);
            GroupBoxEstadoCivil.TabIndex = 1;
            GroupBoxEstadoCivil.TabStop = false;
            GroupBoxEstadoCivil.Text = "Estado Civil";
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
            // botonSeleccionado
            // 
            botonSeleccionado.Location = new Point(186, 335);
            botonSeleccionado.Name = "botonSeleccionado";
            botonSeleccionado.Size = new Size(200, 30);
            botonSeleccionado.TabIndex = 2;
            botonSeleccionado.Text = "Mostrar lo que se selecciono";
            botonSeleccionado.UseVisualStyleBackColor = true;
            botonSeleccionado.Click += button1_Click;
            // 
            // checkedListBoxProfesion
            // 
            checkedListBoxProfesion.FormattingEnabled = true;
            checkedListBoxProfesion.Location = new Point(186, 200);
            checkedListBoxProfesion.Name = "checkedListBoxProfesion";
            checkedListBoxProfesion.Size = new Size(200, 94);
            checkedListBoxProfesion.TabIndex = 3;
            // 
            // labelSeleccionado
            // 
            labelSeleccionado.AutoSize = true;
            labelSeleccionado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSeleccionado.Location = new Point(136, 392);
            labelSeleccionado.Name = "labelSeleccionado";
            labelSeleccionado.Size = new Size(40, 15);
            labelSeleccionado.TabIndex = 4;
            labelSeleccionado.Text = "label1";
            labelSeleccionado.Visible = false;
            // 
            // Ejercicio_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 661);
            Controls.Add(labelSeleccionado);
            Controls.Add(checkedListBoxProfesion);
            Controls.Add(botonSeleccionado);
            Controls.Add(GroupBoxEstadoCivil);
            Controls.Add(GroupBoxSexo);
            Name = "Ejercicio_3";
            Text = "Ejercicio_3";
            FormClosed += Ejercicio_3_FormClosed;
            Load += Ejercicio_3_Load;
            GroupBoxSexo.ResumeLayout(false);
            GroupBoxSexo.PerformLayout();
            GroupBoxEstadoCivil.ResumeLayout(false);
            GroupBoxEstadoCivil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBoxSexo;
        private GroupBox GroupBoxEstadoCivil;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button botonSeleccionado;
        private CheckedListBox checkedListBoxProfesion;
        private RadioButton radioButtonM;
        private RadioButton radioButtonF;
        private RadioButton radioButtonSoltero;
        private RadioButton radioButtonCasado;
        private Label labelSeleccionado;
    }
}