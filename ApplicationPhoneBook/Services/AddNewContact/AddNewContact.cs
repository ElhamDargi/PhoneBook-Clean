using ApplicationPhoneBook.DTO;
using ApplicationPhoneBook.Interfaces;
using DomainPhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.AddNewContact
{
    public class AddNewContact : IAddNewContact
    {
        private readonly IDataBaseContext dataBaseContext;
        public AddNewContact(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public ResultDTO Execute(AddNewContactDTO addNewContactDTO)
        {
            if (string.IsNullOrEmpty(addNewContactDTO.PhoneNumber))
            {
                return (new ResultDTO
                {
                    IsSuccess = true,
                    Message = "Phone Number is a mandatory field!!!",
                });
            }
            Contact newContact = new Contact(addNewContactDTO.Name, addNewContactDTO.LastName, addNewContactDTO.PhoneNumber, addNewContactDTO.Company,addNewContactDTO.Description);
            dataBaseContext.Contacts.Add(newContact);
            dataBaseContext.SaveChanges();
            return (new ResultDTO
            {
                IsSuccess = true,
                Message = $" {addNewContactDTO.Name} {addNewContactDTO.LastName} added to Database",
            });

        }
    }
}
