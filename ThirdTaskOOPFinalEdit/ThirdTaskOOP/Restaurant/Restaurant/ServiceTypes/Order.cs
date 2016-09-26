using RestaurantOOP.RestaurantVisitorsAndStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP.ServiceTypes
{
    public class Order
    {
        public Dictionary<string, List<string>> Orders { get; private set; } = new Dictionary<string, List<string>>();

        public Order(Person visitor, List<string> orderList)
        {
            Orders.Add(visitor.Name, orderList);
        }
    }
}
