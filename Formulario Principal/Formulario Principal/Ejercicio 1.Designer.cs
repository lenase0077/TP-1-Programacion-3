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
            buttonAgregarNombre = new Button();
            listBoxNombres1 = new ListBox();
            labelIngresarNombre = new Label();
            buttonPasarUnItem = new Button();
            buttonPasarMultipleItem = new Button();
            listBoxSalida1 = new ListBox();
            SuspendLayout();
            // 
            // textBoxIngresoNombre
            // 
            textBoxIngresoNombre.Location = new Point(145, 31);
            textBoxIngresoNombre.Name = "textBoxIngresoNombre";
            textBoxIngresoNombre.Size = new Size(284, 23);
            textBoxIngresoNombre.TabIndex = 0;
            textBoxIngresoNombre.KeyPress += textBoxIngresoNombre_KeyPress;
            // 
            // buttonAgregarNombre
            // 
            buttonAgregarNombre.FlatStyle = FlatStyle.System;
            buttonAgregarNombre.Location = new Point(457, 31);
            buttonAgregarNombre.Name = "buttonAgregarNombre";
            buttonAgregarNombre.Size = new Size(75, 23);
            buttonAgregarNombre.TabIndex = 1;
            buttonAgregarNombre.Text = "Agregar";
            buttonAgregarNombre.UseVisualStyleBackColor = true;
            buttonAgregarNombre.Click += buttonAgregarNombre_Click;
            // 
            // listBoxNombres1
            // 
            listBoxNombres1.FormattingEnabled = true;
            listBoxNombres1.Location = new Point(27, 102);
            listBoxNombres1.Name = "listBoxNombres1";
            listBoxNombres1.Size = new Size(207, 304);
            listBoxNombres1.TabIndex = 2;
            listBoxNombres1.SelectedIndexChanged += listBoxNombres1_SelectedIndexChanged;
            // 
            // labelIngresarNombre
            // 
            labelIngresarNombre.AutoSize = true;
            labelIngresarNombre.Location = new Point(27, 34);
            labelIngresarNombre.Name = "labelIngresarNombre";
            labelIngresarNombre.Size = new Size(112, 15);
            labelIngresarNombre.TabIndex = 3;
            labelIngresarNombre.Text = "Ingrese un Nombre:";
            labelIngresarNombre.Click += label1_Click;
            // 
            // buttonPasarUnItem
            // 
            buttonPasarUnItem.Location = new Point(291, 201);
            buttonPasarUnItem.Name = "buttonPasarUnItem";
            buttonPasarUnItem.Size = new Size(75, 23);
            buttonPasarUnItem.TabIndex = 4;
            buttonPasarUnItem.Text = ">";
            buttonPasarUnItem.UseVisualStyleBackColor = true;
            buttonPasarUnItem.Click += buttonPasarUnItem_Click;
            // 
            // buttonPasarMultipleItem
            // 
            buttonPasarMultipleItem.Location = new Point(291, 291);
            buttonPasarMultipleItem.Name = "buttonPasarMultipleItem";
            buttonPasarMultipleItem.Size = new Size(75, 23);
            buttonPasarMultipleItem.TabIndex = 5;
            buttonPasarMultipleItem.Text = ">>";
            buttonPasarMultipleItem.UseVisualStyleBackColor = true;
            buttonPasarMultipleItem.Click += buttonPasarMultipleItem_Click;
            // 
            // listBoxSalida1
            // 
            listBoxSalida1.FormattingEnabled = true;
            listBoxSalida1.Location = new Point(407, 100);
            listBoxSalida1.Name = "listBoxSalida1";
            listBoxSalida1.Size = new Size(207, 304);
            listBoxSalida1.TabIndex = 7;
            // 
            // Ejercicio_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxSalida1);
            Controls.Add(buttonPasarMultipleItem);
            Controls.Add(buttonPasarUnItem);
            Controls.Add(labelIngresarNombre);
            Controls.Add(listBoxNombres1);
            Controls.Add(buttonAgregarNombre);
            Controls.Add(textBoxIngresoNombre);
            Name = "Ejercicio_1";
            Text = "Ejercicio_1";
            FormClosed += Ejercicio_1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIngresoNombre;
        private Button buttonAgregarNombre;
        private ListBox listBoxNombres1;
        private Label labelIngresarNombre;
        private Button buttonPasarUnItem;
        private Button buttonPasarMultipleItem;
        private ListBox listBoxSalida1;
    }
}