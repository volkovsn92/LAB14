using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP.RestaurantVisitorsAndStaff
{
    public abstract class Person: IPerson
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
        }

        public abstract void DealWithIt();
    }
}
