namespace SectionC_Question1._1
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
            lblOutput = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCode = new TextBox();
            txtMake = new TextBox();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            tblMobilePhones = new ListBox();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(68, 54);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(46, 20);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Temp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 132);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Mobile Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 178);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 233);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Quantity";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(204, 129);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 4;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(204, 178);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(204, 226);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(91, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(216, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(347, 315);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // tblMobilePhones
            // 
            tblMobilePhones.FormattingEnabled = true;
            tblMobilePhones.Location = new Point(480, 54);
            tblMobilePhones.Name = "tblMobilePhones";
            tblMobilePhones.Size = new Size(369, 284);
            tblMobilePhones.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 450);
            Controls.Add(tblMobilePhones);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtMake);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCode;
        private TextBox txtMake;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private ListBox tblMobilePhones;
    }
}
