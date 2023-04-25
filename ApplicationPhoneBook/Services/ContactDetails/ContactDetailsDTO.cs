namespace ApplicationPhoneBook.Services.ContactDetails
{
    public class ContactDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
