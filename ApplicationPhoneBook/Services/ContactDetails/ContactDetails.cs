using ApplicationPhoneBook.DTO;
using ApplicationPhoneBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.ContactDetails
{
    public class ContactDetails : IContactDetails
    {
        private readonly IDataBaseContext dataBaseContext;

        public ContactDetails(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }
        public ResultDTO<ContactDetailsDTO> Execute(int contactId)
        {
            var contact = dataBaseContext.Contacts.Find(contactId);
            if (contact == null)
            {
                return new ResultDTO<ContactDetailsDTO>
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "This contact does not exist!!"
                };
            }
            else
            {
                ContactDetailsDTO contactDetails = new ContactDetailsDTO()
                {
                    Id = contactId,
                    Name = contact.Name,
                    LastName = contact.LastName,
                    PhoneNumber = contact.PhoneNumber,
                    Company = contact.Company,
                    Description = contact.Description,
                    TimeCreated = contact.TimeCreated
                };
                return new ResultDTO<ContactDetailsDTO>
                {
                    IsSuccess = true,
                    Data = contactDetails
                };
            }
        }
    }
}
