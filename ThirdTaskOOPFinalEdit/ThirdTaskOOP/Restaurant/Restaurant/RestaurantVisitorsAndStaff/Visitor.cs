using RestaurantOOP.ServiceTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP.RestaurantVisitorsAndStaff
{
    public class Visitor : Person
    {

        public List<string> WishList { get; private set; } = new List<string>();
        public List<string> OrderList { get; private set; } = new List<string>();
        public List<Dish> Table { get; set; } = new List<Dish>();
        public Restaurant Restaurant { get; private set; }

        public Visitor(string name, Restaurant restaurant) : base(name)
        {
            Restaurant = restaurant;
        }

        //составляем список того, что посетитель хочет съесть и сверяем с тем, что есть в меню,
        //если что-то имеется - будем готовить, если нет - уходим
        public void MakeWishList(params string[] dishes)
        {
            foreach (var item in dishes)
            {
                WishList.Add(item);
            }
        }

        public void Come()   // Приходим в ресторан и отмечаемся в книге гостей (ListOfVisitors)
        {
            Restaurant.ListOfVisitors.Add(this);
        }

        public void Leave() // Уходим
        {
            Restaurant.ListOfVisitors.Remove(this);
        }

        public void MakeOrderList() // Делаем то, что нужно по роли, в данном случае заказ
        {
            for (int i = 0; i < WishList.Count; i++)
            {
                if (MenuClass.Menu.Contains(WishList[i])){
                    OrderList.Add(WishList[i]);
                }
            }

            if (OrderList.Count == 0)
            {
                Leave();
            }
        }

        public  void EatOrNot() // сверяем заказанное с принесенным
        {
            foreach (var item in Table)
            {
                if (OrderList.Contains(item.Name))
                {
                    Console.WriteLine($"Omnomnom {item.Name}");
                }
                else
                {
                    Console.WriteLine($"ARRRRGH!!! What has you brought to me? {item.Name}?!!");
                }
            }
        }

        public override void DealWithIt()
        {
            Console.WriteLine($"{Name} done!");
        }
    }
}
