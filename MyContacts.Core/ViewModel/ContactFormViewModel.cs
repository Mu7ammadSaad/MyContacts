using MyContacts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyContacts.Core.ViewModel
{
    public class ContactFormViewModel
    {
        public Contact Contact { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}
