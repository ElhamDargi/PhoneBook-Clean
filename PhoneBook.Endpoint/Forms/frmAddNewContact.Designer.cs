namespace UI.Forms
{
    partial class frmAddNewContact
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtNumber = new TextBox();
            txtCompany = new TextBox();
            txtDescription = new TextBox();
            btnBack = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(124, 40);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 0;
            label1.Text = "Add New Contact ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(49, 137);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(49, 181);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(49, 232);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(49, 276);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 4;
            label5.Text = "Company";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(49, 329);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 5;
            label6.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new Point(207, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 31);
            txtName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(207, 184);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(330, 31);
            txtLastName.TabIndex = 7;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(207, 235);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(330, 31);
            txtNumber.TabIndex = 8;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(207, 279);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(330, 31);
            txtCompany.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(207, 326);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(330, 184);
            txtDescription.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(70, 544);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(202, 34);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(324, 544);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(202, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddNewContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(602, 628);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(txtDescription);
            Controls.Add(txtCompany);
            Controls.Add(txtNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddNewContact";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddNewContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtNumber;
        private TextBox txtCompany;
        private TextBox txtDescription;
        private Button btnBack;
        private Button btnAdd;
    }
}