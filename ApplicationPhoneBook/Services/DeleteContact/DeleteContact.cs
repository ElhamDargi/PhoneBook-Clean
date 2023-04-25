using ApplicationPhoneBook.DTO;
using ApplicationPhoneBook.Interfaces;

namespace ApplicationPhoneBook.Services.DeleteContact
{
    public class DeleteContact : IDeleteContact
    {
        private readonly IDataBaseContext dataBaseContext;

        public DeleteContact(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public ResultDTO Execute(int contactId)
        {
            var contact = dataBaseContext.Contacts.Find(contactId);
            if (contact != null)
            {
                dataBaseContext.Contacts.Remove(contact);
                dataBaseContext.SaveChanges();
                return new ResultDTO()
                {
                    IsSuccess = true,
                    Message = "Your Cantact deleted successfully!!"
                };
            }
            else
            {
                return new ResultDTO()
                {
                    IsSuccess = false,
                    Message = "Your Cantact does not exist!!"
                };
            }
        }
    }
}
