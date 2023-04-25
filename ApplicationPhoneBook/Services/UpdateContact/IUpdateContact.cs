using ApplicationPhoneBook.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationPhoneBook.Services.UpdateContact
{
    public interface IUpdateContact
    {
        ResultDTO Execute(UpdateContactDTO updateContactDTO);
    }
}
