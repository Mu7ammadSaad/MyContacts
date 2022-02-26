using MyContacts.Data;
using System.Collections.Generic;

namespace MyContacts.Infrastructre
{
    public interface IContactsRepo
    {
        IEnumerable<Contact> GetAllContacts();
        Contact GetContactById(int Id);

        void AddContact(Contact contact);
        Contact DeleteContact(int Id);

    }
}