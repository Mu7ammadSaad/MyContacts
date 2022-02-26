using MyContacts.Data;
using System.Collections.Generic;

namespace MyContacts.Infrastructre
{
    public interface ICitiesRepo
    {
        public IEnumerable<City> GetAllCities();

        City GetCityById(int Id);
    }
}