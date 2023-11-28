namespace StudentGradeForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "21CS1001", "21CS1002", "21CS1003", "21CS1004", "21CS1005", "21CS1006", "21CS1007", "21CS1008", "21CS1009", "21CS1010" });
            comboBox1.Location = new Point(556, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(434, 25);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Registration No:-";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(556, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 25);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:-";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 82);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 1;
            label3.Text = "Department:-";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 87);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 1;
            label4.Text = "Semester:-";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 193);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 1;
            label5.Text = "English";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 245);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 1;
            label6.Text = "Urdu";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 295);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 1;
            label7.Text = "Mathematics";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 347);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 1;
            label8.Text = "Science";
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 157);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 1;
            label9.Text = "SUBJECTS";
            label9.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(413, 157);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 1;
            label10.Text = "MARKS";
            label10.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(348, 193);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(348, 237);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(348, 287);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 3;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(348, 339);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 3;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(344, 400);
            button1.Name = "button1";
            button1.Size = new Size(168, 36);
            button1.TabIndex = 4;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Student Grade From";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Button button1;
    }
}