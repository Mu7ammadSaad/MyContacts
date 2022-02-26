using MyContacts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Infrastructre
{
    public class ContactsRepo : IContactsRepo
    {
        static AppDbContext context = new();

        public Contact DeleteContact(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return context.Contacts;
        }

        public Contact GetContactById(int Id)
        {
            throw new NotImplementedException();
        }

        public void AddContact(Contact contact)
        {
            context.Contacts.Add(contact);

            //return "Contact Saved Successfully";
        }
    }
}
