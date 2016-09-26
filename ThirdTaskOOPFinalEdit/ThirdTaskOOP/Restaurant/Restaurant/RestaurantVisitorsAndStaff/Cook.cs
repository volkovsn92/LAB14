using RestaurantOOP.ServiceTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP.RestaurantVisitorsAndStaff
{
    public class Cook : Person
    {
        public Restaurant Restaurant { get; private set; }
        public Dictionary<string, List<Dish>> DishesCooked { get; private set; } = new Dictionary<string, List<Dish>>();
        public Cook(string name, Restaurant restaurant) : base(name)
        {
            Restaurant = restaurant;
        }

        //мракобесие небольшое, но тем не менее:
        public void Cooking(List<Order> OrdersTaken) 
        {
            List<Dish> listOfDishesForOrder = new List<Dish>();
            //for (int i = 0, k = 0; i < OrdersTaken[k].Orders.Count; i++, k++) //для всех принятых заказов
            foreach (var item0 in OrdersTaken)
            {
                foreach (var item in item0.Orders)       //извлекаем имена яств  
                {
                    for (int j = 0; j < item.Value.Count; j++)    //по названиям яств готовим блюда и закидываем их в коллекцию готовых блюд
                    {
                        
                        listOfDishesForOrder.Add(new Dish(item.Value[j]));
                    }
                    
                }

                foreach (var item in item0.Orders) //здесь формируем готовые заказы, ключ - имя посетителя, значение - лист готовых блюд
                {
                    DishesCooked.Add(item.Key, listOfDishesForOrder);
                }
            }
            // сейчас по прошествии пары дней я понял, что имя пользователя может быть неоригинальным и повторяющимся... и здесь лучше использовать стринговый ID...
        }

        public override void DealWithIt()
        {
            Console.WriteLine($"{Name} done!");
        }
    }
}
