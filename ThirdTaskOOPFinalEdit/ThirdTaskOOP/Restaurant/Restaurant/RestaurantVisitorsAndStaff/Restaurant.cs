using RestaurantOOP.RestaurantVisitorsAndStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP.RestaurantVisitorsAndStaff
{
    public class Restaurant
    {
        public string Name { get; private set; }
        public List<Visitor> ListOfVisitors { get; private set; } = new List<Visitor>();

        public Restaurant(string name)
        {
            Name = name;
        }
    }
}
