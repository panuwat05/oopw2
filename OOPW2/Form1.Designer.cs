namespace OOPW2
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
            label1 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            Result = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 69);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Num 1";
            label1.Click += label1_Click;
            // 
            // num1
            // 
            num1.Location = new Point(162, 66);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 1;
            // 
            // num2
            // 
            num2.Location = new Point(162, 107);
            num2.Name = "num2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 110);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Num 2";
            // 
            // button1
            // 
            button1.Location = new Point(289, 66);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 149);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // Result
            // 
            Result.Location = new Point(162, 146);
            Result.Name = "Result";
            Result.Size = new Size(100, 23);
            Result.TabIndex = 6;
            Result.TextChanged += Result_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(322, 66);
            button2.Name = "button2";
            button2.Size = new Size(31, 23);
            button2.TabIndex = 7;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(289, 102);
            button3.Name = "button3";
            button3.Size = new Size(27, 23);
            button3.TabIndex = 8;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(322, 102);
            button4.Name = "button4";
            button4.Size = new Size(31, 23);
            button4.TabIndex = 9;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(289, 145);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Result);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num1;
        private TextBox num2;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox Result;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
