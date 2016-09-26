using RestaurantOOP.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP.ServiceTypes
{
    public class MenuClass
    {
        public static string[] Menu { get; private set; } = { DishesNames.SpaghettiBolognese,
                                                      DishesNames.Cake,
                                                      DishesNames.Salad,
                                                      DishesNames.Coffee };
    }
}
