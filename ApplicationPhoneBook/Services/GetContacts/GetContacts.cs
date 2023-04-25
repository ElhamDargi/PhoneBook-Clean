using ApplicationPhoneBook.Interfaces;

namespace ApplicationPhoneBook.Services.GetContacts
{
    public class GetContacts : IGetContacts
    {
        private readonly IDataBaseContext dataBaseContext;

        public GetContacts(IDataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;
        }

        public List<GetContactsDTO> Execute(string searchKey = null)
        {
            var query = dataBaseContext.Contacts.AsQueryable();
            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(p =>
                p.Name.Contains(searchKey)
                ||
                p.LastName.Contains(searchKey)
                ||
                p.Company.Contains(searchKey)
                  ||
                p.PhoneNumber.Contains(searchKey)
                );
            }
            var contactList = query.Select(i => new GetContactsDTO
            {
                Id = i.Id,
                FullName = $"{i.Name} {i.LastName}",
                PhoneNumber = i.PhoneNumber
            }).ToList();

            return contactList;
        }
    }
}
