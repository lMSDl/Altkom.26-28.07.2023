using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Adapter.II
{
    internal class DbPeopleServiceAdapter : IPeopleService
    {
        private readonly DbService _dbService;
        public DbPeopleServiceAdapter(DbService dbService)
        {
            _dbService = dbService;
        }

        public IEnumerable<Person> GetPeople()
        {
            return _dbService.Read().Select(x => new Person { Name = $"{x.FirstName} {x.LastName}", Age = DateTime.Now.Year - x.BirthDate.Year });
        }
    }
}
