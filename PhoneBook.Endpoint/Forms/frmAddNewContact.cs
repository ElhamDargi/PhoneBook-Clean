
using ApplicationPhoneBook.Services.AddNewContact;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmAddNewContact : Form
    {
        private readonly IAddNewContact addNewContact;
        public frmAddNewContact(IAddNewContact addNewContact)
        {
            InitializeComponent();
            this.addNewContact = addNewContact;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = addNewContact.Execute(new AddNewContactDTO
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Company = txtCompany.Text,
                Description = txtDescription.Text,
                PhoneNumber = txtNumber.Text
            });
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
