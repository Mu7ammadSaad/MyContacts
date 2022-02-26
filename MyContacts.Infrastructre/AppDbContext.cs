using Microsoft.EntityFrameworkCore;
using MyContacts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Infrastructre
{
    public class AppDbContext
    {
        public AppDbContext()
        {
            Cities = new List<City>
            {
                new City{Id = 1, Name ="Riyadh"},
                new City{Id = 2, Name ="Jeddah"},
                new City{Id = 3, Name = "Mekkah"},
                new City{Id = 4, Name = "Madinah"},
                new City{Id = 5, Name = " Shaqra"},
            };

            Contacts = new List<Contact>
            {
                new Contact {Id = 1, FullName="Mohamed" , Address ="some data", Phone ="0123456789", City = Cities[1]},
                new Contact {Id = 2, FullName="Ahmed" , Address ="some data", Phone ="0123456789", City = Cities[2] },
                new Contact {Id = 3, FullName="Mahmoud" , Address ="some data", Phone ="0123456789", City = Cities[3] },
                new Contact {Id = 4, FullName="Abdullah" , Address ="some data", Phone ="0123456789", City = Cities[4] },
                new Contact {Id = 5, FullName="Abdulrahman" , Address ="some data", Phone ="0123456789", City = Cities[4] },
           };
        }

        public List<City> Cities { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
