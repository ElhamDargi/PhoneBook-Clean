using ApplicationPhoneBook.DTO;
using ApplicationPhoneBook.Interfaces;
using DomainPhoneBook.Entities;

namespace ApplicationPhoneBook.Services.UpdateContact
{
    public class UpdateContact : IUpdateContact
    {
        private readonly IDataBaseContext dataBaseContact;

        public UpdateContact(IDataBaseContext dataBaseContact)
        {
            this.dataBaseContact = dataBaseContact;
        }

        public ResultDTO Execute(UpdateContactDTO updateContactDTO)
        {
            int Id=updateContactDTO.Id;
            var contact = dataBaseContact.Contacts.Find(Id);
            if (contact == null)
            {
                return new ResultDTO
                {
                    IsSuccess = false,
                    Message = "This contact does not exist!!!"
                };
            }
            else
            {
                contact.UpdateContact(updateContactDTO.Name,updateContactDTO.LastName,updateContactDTO.PhoneNumber,updateContactDTO.Company,updateContactDTO.Description);
                dataBaseContact.SaveChanges();
                return new ResultDTO
                {
                    IsSuccess = true,
                    Message = "Update did successfully!!!"
                };
            }
        }
    }
}
