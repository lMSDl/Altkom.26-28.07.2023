using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Adapter.II
{
    public interface IPeopleService
    {
        IEnumerable<Person> GetPeople();
    }
}
