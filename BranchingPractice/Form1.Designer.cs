namespace BranchingPractice
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
            btnDisplayGreeting = new Button();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDisplayGreeting
            // 
            btnDisplayGreeting.Location = new Point(40, 108);
            btnDisplayGreeting.Name = "btnDisplayGreeting";
            btnDisplayGreeting.Size = new Size(120, 57);
            btnDisplayGreeting.TabIndex = 0;
            btnDisplayGreeting.Text = "Display Greeting";
            btnDisplayGreeting.UseVisualStyleBackColor = true;
            btnDisplayGreeting.Click += btnDisplayGreeting_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 27);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 2;
            label1.Text = "Write your name!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 200);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnDisplayGreeting);
            Name = "Form1";
            Text = "Branching Practice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplayGreeting;
        private TextBox txtName;
        private Label label1;
    }
}
