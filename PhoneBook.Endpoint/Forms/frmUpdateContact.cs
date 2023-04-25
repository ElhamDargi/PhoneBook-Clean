
using ApplicationPhoneBook.Services.ContactDetails;
using ApplicationPhoneBook.Services.UpdateContact;
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
    public partial class frmUpdateContact : Form
    {
        private readonly IUpdateContact updateContact;
        private readonly IContactDetails contactDetails;
        private readonly int contactId;

        public frmUpdateContact(IUpdateContact updateContact, IContactDetails contactDetails, int contactId)
        {
            InitializeComponent();
            this.updateContact = updateContact;
            this.contactDetails = contactDetails;
            this.contactId = contactId;
        }
        private void frmUpdateContact_Load(object sender, EventArgs e)
        {
            var contact = contactDetails.Execute(contactId);
            if (!contact.IsSuccess)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtCompany.Text = contact.Data.Company;
                txtDescription.Text = contact.Data.Description;
                txtLastName.Text = contact.Data.LastName;
                txtName.Text = contact.Data.Name;
                txtNumber.Text = contact.Data.PhoneNumber;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateContactDTO updateContactDTO = new UpdateContactDTO()
            {
                Id = this.contactId,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtNumber.Text,
                Company = txtCompany.Text,
                Description = txtDescription.Text
            };
            var result = updateContact.Execute(updateContactDTO);
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


    }
}
