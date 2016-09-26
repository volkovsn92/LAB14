﻿using RestaurantOOP.ServiceTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP.RestaurantVisitorsAndStaff
{
    public class Waiter : Person
    {
        public List<Order> OrdersTaken { get; private set; } = new List<Order>();
        public Restaurant Restaurant { get; private set; }

        public Waiter(string name, Restaurant restaurant) : base(name)
        {
            Restaurant = restaurant;
        }

        public void TakeOrder(Person visitor, List<string> orderList)
        {
            Order order = new Order(visitor, orderList);
            OrdersTaken.Add(order);
            
        }

        public override void DealWithIt()
        {
            Console.WriteLine($"{Name} done!");
        }

        public void GiveOrder(Dictionary<string, List<Dish>> dishes)
        {
            foreach (var item in dishes)
            {
                for (int i = 0; i < Restaurant.ListOfVisitors.Count; i++)
                {
                    if (Restaurant.ListOfVisitors[i].Name.Equals(item.Key))
                    {
                        Restaurant.ListOfVisitors[i].Table = item.Value;
                    }
                }
            }
        }
    }
}
