
using ApplicationPhoneBook.Interfaces;
using ApplicationPhoneBook.Services.AddNewContact;
using ApplicationPhoneBook.Services.ContactDetails;
using ApplicationPhoneBook.Services.DeleteContact;
using ApplicationPhoneBook.Services.GetContacts;
using ApplicationPhoneBook.Services.UpdateContact;
using PersistencePhoneBook.Context;
using PhoneBook.Endpoint;
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
    public partial class frmMain : Form
    {
        private readonly IGetContacts getContacts;
        private readonly IDeleteContact deleteContact;
        private readonly IContactDetails contactDetails;
        private readonly IUpdateContact updateContact;

        public frmMain(IGetContacts getContacts, IDeleteContact deleteContact, IContactDetails contactDetails, IUpdateContact updateContact)
        {
            InitializeComponent();
            this.getContacts = getContacts;
            this.deleteContact = deleteContact;
            this.contactDetails = contactDetails;
            this.updateContact = updateContact;
        }

        private void SettingGridview(List<GetContactsDTO> contactList)
        {
            dataGridView1.DataSource = contactList;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Phone Number";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 200;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var contactList = getContacts.Execute();
            SettingGridview(contactList);
            this.Cursor = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var contactList = getContacts.Execute(searchKey.Text);
            SettingGridview(contactList);
            this.Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = deleteContact.Execute(Id);
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain_Load(null, null);
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ShowDetails();
        }

        private void ShowDetails()
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmContactDetails frmContactDetails = new frmContactDetails(contactDetails, Id);
            frmContactDetails.ShowDialog();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            //IAddNewContact addNew = new AddNewContact(new DataBaseContext());
            //frmAddNewContact frmContact = new frmAddNewContact(addNew);

            var serviceAdd = (IAddNewContact)Program.ServiceProvider.GetService(typeof(IAddNewContact));
            frmAddNewContact frmContact = new frmAddNewContact(serviceAdd);
            frmContact.ShowDialog();
            frmMain_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmUpdateContact frmUpdateContact = new frmUpdateContact(updateContact, contactDetails, Id);
            frmUpdateContact.ShowDialog();
            frmMain_Load(null, null);
        }
    }
}
