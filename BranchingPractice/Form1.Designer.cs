﻿namespace BranchingPractice
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
            txtName = new TextBox();
            BtnDisplayGreeting = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Write your name!";
            // 
            // txtName
            // 
            txtName.Location = new Point(17, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 23);
            txtName.TabIndex = 4;
            // 
            // BtnDisplayGreeting
            // 
            BtnDisplayGreeting.Location = new Point(45, 111);
            BtnDisplayGreeting.Name = "BtnDisplayGreeting";
            BtnDisplayGreeting.Size = new Size(120, 57);
            BtnDisplayGreeting.TabIndex = 3;
            BtnDisplayGreeting.Text = "Display Greeting";
            BtnDisplayGreeting.UseVisualStyleBackColor = true;
            BtnDisplayGreeting.Click += BtnDisplayGreeting_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 222);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(BtnDisplayGreeting);
            Name = "Form1";
            Text = "Branching Practice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button BtnDisplayGreeting;
    }
}
