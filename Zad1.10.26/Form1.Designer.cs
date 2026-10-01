namespace Zad1._10._26
{
    partial class Form1
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
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            txtЕdit = new TextBox();
            cmdSave = new Button();
            cmdCombo = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Запис 1", "Запис 2", "Запис 3", "Запис 4", "Запис 5", "Запис 6", "Запис 7", "Запис 8", "Запис 9", "Запис 10" });
            listBox1.Location = new Point(29, 94);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(153, 169);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(197, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 54);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 2;
            label1.Text = "Изберете запис";
            // 
            // txtЕdit
            // 
            txtЕdit.Location = new Point(197, 199);
            txtЕdit.Name = "txtЕdit";
            txtЕdit.Size = new Size(161, 23);
            txtЕdit.TabIndex = 3;
            // 
            // cmdSave
            // 
            cmdSave.Location = new Point(197, 123);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(161, 53);
            cmdSave.TabIndex = 4;
            cmdSave.Text = "Зареждане на данни в комбинираната кутия";
            cmdSave.UseVisualStyleBackColor = true;
            cmdSave.Click += cmdSave_Click;
            // 
            // cmdCombo
            // 
            cmdCombo.Location = new Point(197, 228);
            cmdCombo.Name = "cmdCombo";
            cmdCombo.Size = new Size(161, 37);
            cmdCombo.TabIndex = 5;
            cmdCombo.Text = "Съхраняване";
            cmdCombo.UseVisualStyleBackColor = true;
            cmdCombo.Click += cmdCombo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdCombo);
            Controls.Add(cmdSave);
            Controls.Add(textBox1);
            Controls.Add(txtЕdit);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox txtЕdit;
        private Button cmdSave;
        private Button cmdCombo;
        private TextBox textBox1;
    }
}
