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
            groupBox1 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // GroupBoxSexo
            // 
            GroupBoxSexo.Location = new Point(80 ,51);
            GroupBoxSexo.Name = "GroupBoxSexo";
            GroupBoxSexo.Size = new Size(150 ,100);
            GroupBoxSexo.TabIndex = 0;
            GroupBoxSexo.TabStop = false;
            GroupBoxSexo.Text = "Sexo";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(361 ,51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(150 ,100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado Civil";
            // 
            // button1
            // 
            button1.Location = new Point(186 ,385);
            button1.Name = "button1";
            button1.Size = new Size(200 ,30);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(186 ,200);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(200 ,94);
            checkedListBox1.TabIndex = 3;
            // 
            // Ejercicio_3
            // 
            AutoScaleDimensions = new SizeF(7F ,15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584 ,661);
            Controls.Add(checkedListBox1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxSexo);
            Name = "Ejercicio_3";
            Text = "Ejercicio_3";
            FormClosed +=  Ejercicio_3_FormClosed ;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxSexo;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private CheckedListBox checkedListBox1;
    }
}