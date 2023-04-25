using DomainPhoneBook.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Interfaces
{
    public interface IDataBaseContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public int SaveChanges();
    }
}
