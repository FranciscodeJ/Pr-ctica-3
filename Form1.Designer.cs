﻿namespace Práctica__3
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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("BankGothic Md BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 85);
            label1.Name = "label1";
            label1.Size = new Size(242, 30);
            label1.TabIndex = 0;
            label1.Text = "Primer número";
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Subheading", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(387, 243);
            button1.Name = "button1";
            button1.Size = new Size(194, 77);
            button1.TabIndex = 3;
            button1.Text = "SUMAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(362, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 43);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(362, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 43);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("BankGothic Md BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 148);
            label2.Name = "label2";
            label2.Size = new Size(276, 30);
            label2.TabIndex = 7;
            label2.Text = "Segundo número";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("BankGothic Md BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(125, 271);
            label3.Name = "label3";
            label3.Size = new Size(110, 30);
            label3.TabIndex = 8;
            label3.Text = "Sum =";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}