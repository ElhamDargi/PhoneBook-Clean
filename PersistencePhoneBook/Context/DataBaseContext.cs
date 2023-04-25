using ApplicationPhoneBook.Interfaces;
using DomainPhoneBook.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistencePhoneBook.Context
{
    public class DataBaseContext:DbContext ,IDataBaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=DBPhonebook-Clean; Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
