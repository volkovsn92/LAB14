using RestaurantOOP.RestaurantVisitorsAndStaff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant(Constants.Names.RestName); // создаем ресторан с именем

            Visitor visitorIvan = new Visitor(Constants.Names.Ivan, restaurant); //создаем посетителя, указываем куда он "хочет пойти"
            visitorIvan.Come(); // Приводим Ваню в ресторан. Можем создать несколько посетителей

            Waiter waiterLucy = new Waiter(Constants.Names.Lucy, restaurant); // создаем официантку Люси, "устраиваем" ее на работу в ресторан

            Cook cookJuanita = new Cook(Constants.Names.Juanita, restaurant); // создаем повара Хуаниту и берем на работу

            visitorIvan.MakeWishList("Marcipan", "Coffee", "Cake"); // Ваня думает, что хотел бы съесть
            visitorIvan.MakeOrderList(); // Ваня сверяется с меню

            waiterLucy.TakeOrder(visitorIvan, visitorIvan.OrderList); // Люси берет у Вани заказ, если Ваня не нашел, что заказать и ушел, то ничего не случится) 
            
            cookJuanita.Cooking(waiterLucy.OrdersTaken); // Повар Хуанита берет заказ у Люси, готовит и ставит на поднос

            waiterLucy.GiveOrder(cookJuanita.DishesCooked); // Люси берет блюда с подноса Хуаниты и несет за столик Ивана

            visitorIvan.EatOrNot(); // Ваня проверяет, все ли принесли, если все ок - кушает

            Console.ReadLine();

        }
    }
}
