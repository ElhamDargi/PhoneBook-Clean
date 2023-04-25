namespace UI.Forms
{
    partial class frmMain
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
            dataGridView1 = new DataGridView();
            searchKey = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            btnDelete = new Button();
            btnDetails = new Button();
            btnAddContact = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(669, 486);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // searchKey
            // 
            searchKey.Location = new Point(169, 30);
            searchKey.Margin = new Padding(2, 3, 2, 3);
            searchKey.Name = "searchKey";
            searchKey.Size = new Size(242, 33);
            searchKey.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(444, 30);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(139, 26);
            label1.TabIndex = 3;
            label1.Text = "Enter your text :";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(158, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(176, 92);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(158, 34);
            btnDetails.TabIndex = 5;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(340, 92);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(158, 34);
            btnAddContact.TabIndex = 6;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(504, 92);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 34);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Contact";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 634);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddContact);
            Controls.Add(btnDetails);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(searchKey);
            Controls.Add(dataGridView1);
            Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Contacts";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox searchKey;
        private Button btnSearch;
        private Label label1;
        private Button btnDelete;
        private Button btnDetails;
        private Button btnAddContact;
        private Button btnUpdate;
    }
}