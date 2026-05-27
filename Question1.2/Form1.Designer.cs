namespace Question1._2
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
            btnGreeting = new Button();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGreeting
            // 
            btnGreeting.Location = new Point(449, 233);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(125, 41);
            btnGreeting.TabIndex = 0;
            btnGreeting.Text = "Greeting";
            btnGreeting.UseVisualStyleBackColor = true;
            btnGreeting.Click += btnGreeting_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(305, 180);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 180);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter your name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnGreeting);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGreeting;
        private TextBox txtName;
        private Label label1;
    }
}
