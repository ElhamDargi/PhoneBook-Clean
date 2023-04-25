using ApplicationPhoneBook.Interfaces;
using ApplicationPhoneBook.Services.AddNewContact;
using ApplicationPhoneBook.Services.ContactDetails;
using ApplicationPhoneBook.Services.DeleteContact;
using ApplicationPhoneBook.Services.GetContacts;
using ApplicationPhoneBook.Services.UpdateContact;
using Microsoft.Extensions.DependencyInjection;
using PersistencePhoneBook.Context;
using System.ComponentModel;
using UI.Forms;

namespace PhoneBook.Endpoint
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void OnCounfiguring()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDataBaseContext, DataBaseContext>();
            services.AddScoped<IAddNewContact, AddNewContact>();
            services.AddScoped<IGetContacts, GetContacts>();
            services.AddScoped<IDeleteContact,DeleteContact>();
            services.AddScoped<IContactDetails,ContactDetails>();
            services.AddScoped<IUpdateContact, UpdateContact>(); 

            services.AddDbContext<DataBaseContext>();

            ServiceProvider = services.BuildServiceProvider();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OnCounfiguring();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var service_Get =(IGetContacts) ServiceProvider.GetService(typeof(IGetContacts));
            var service_Delete =(IDeleteContact) ServiceProvider.GetService(typeof(IDeleteContact));
            var service_Details=(IContactDetails)ServiceProvider.GetService(typeof(IContactDetails));
            var service_Update = (IUpdateContact)ServiceProvider.GetService(typeof(IUpdateContact));


            Application.Run(new frmMain(service_Get,service_Delete, service_Details, service_Update));
        }
    }
}