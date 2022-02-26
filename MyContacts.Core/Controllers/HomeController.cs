using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyContacts.Core.Models;
using MyContacts.Core.ViewModel;
using MyContacts.Data;
using MyContacts.Infrastructre;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyContacts.Core.Controllers
{
    public class HomeController : Controller
    {

        ContactsRepo contacts = new();
        CitiesRepo cities = new();
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            IEnumerable<Contact> allContacts = contacts.GetAllContacts();
            return View(allContacts);
        }

        public IActionResult AddNewContact()
        {

            ContactFormViewModel vm = new ContactFormViewModel()
            {
                Cities = cities.GetAllCities()
            };
            return View(vm);
        }
        [HttpPost]
        public IActionResult AddNewContact(Contact contact)
        {
            if(ModelState.IsValid)
            {
                var contactsCount = contacts.GetAllContacts().Count();
                contact.Id = contactsCount + 1;
                contact.City = cities.GetCityById(contact.City.Id);
                contacts.AddContact(contact);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
