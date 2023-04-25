namespace UI.Forms
{
    partial class frmUpdateContact
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
            btnUpdate = new Button();
            btnBack = new Button();
            txtDescription = new TextBox();
            txtCompany = new TextBox();
            txtNumber = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(330, 556);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(202, 34);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(76, 556);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(202, 34);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(213, 338);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(330, 184);
            txtDescription.TabIndex = 23;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(213, 291);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(330, 31);
            txtCompany.TabIndex = 22;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(213, 247);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(330, 31);
            txtNumber.TabIndex = 21;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(213, 196);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(330, 31);
            txtLastName.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(213, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 31);
            txtName.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(55, 341);
            label6.Name = "label6";
            label6.Size = new Size(109, 25);
            label6.TabIndex = 18;
            label6.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(55, 288);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 17;
            label5.Text = "Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(55, 244);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 16;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(55, 193);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 15;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(55, 149);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(130, 52);
            label1.Name = "label1";
            label1.Size = new Size(261, 37);
            label1.TabIndex = 13;
            label1.Text = "Update Contact ";
            // 
            // frmUpdateContact
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(602, 628);
            Controls.Add(btnUpdate);
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
            Name = "frmUpdateContact";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmUpdateContact";
            Load += frmUpdateContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnBack;
        private TextBox txtDescription;
        private TextBox txtCompany;
        private TextBox txtNumber;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}