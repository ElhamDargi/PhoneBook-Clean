
using ApplicationPhoneBook.Services.ContactDetails;
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
    public partial class frmContactDetails : Form
    {
        private readonly IContactDetails contactDetails;

        public int contactId { get; set; }

        public frmContactDetails(IContactDetails contactDetails, int contactId)
        {
            InitializeComponent();
            this.contactDetails = contactDetails;
            this.contactId = contactId;
        }
        private void frmContactDetails_Load(object sender, EventArgs e)
        {
            var contact = contactDetails.Execute(contactId);
            if (!contact.IsSuccess)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblCompany.Text = contact.Data.Company;
            lblCreatedTime.Text = contact.Data.TimeCreated.ToString();
            lblDescription.Text = contact.Data.Description;
            lblId.Text = contact.Data.Id.ToString();
            lblLastName.Text = contact.Data.LastName;
            lblName.Text = contact.Data.Name;
            lblPhoneNumber.Text = contact.Data.PhoneNumber;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
