using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainPhoneBook.Entities
{
    public class Contact
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Company { get; private set; }
        public string Description { get; private set; }
        public DateTime TimeCreated { get; private set; }
        public Contact()
        {

        }
        public Contact(string Name, string LastName, string PhoneNumber, string Company, string Description)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Company = Company;
            this.Description = Description;
            this.TimeCreated = DateTime.Now;
        }

        public void UpdateContact(string Name, string LastName, string PhoneNumber, string Company, string Description)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Company = Company;
            this.Description = Description;
            this.TimeCreated = DateTime.Now;
        }
    }
}
