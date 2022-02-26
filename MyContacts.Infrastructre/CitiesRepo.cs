using MyContacts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContacts.Infrastructre
{
    public class CitiesRepo : ICitiesRepo
    {
        static AppDbContext _context = new();

        public IEnumerable<City> GetAllCities()
        {
            return _context.Cities;
        }
        public City GetCityById(int cityId)
        {
           return  _context.Cities.FirstOrDefault(p =>p.Id == cityId);
        }
    }
}
