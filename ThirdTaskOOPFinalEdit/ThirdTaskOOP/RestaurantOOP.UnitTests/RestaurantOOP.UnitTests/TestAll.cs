using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using RestaurantOOP;
using RestaurantOOP.RestaurantVisitorsAndStaff;

namespace RestaurantOOPUnitTests
{
    [TestClass]
    public class TestAll
    {
        [TestMethod]
        public void Restaurant_Test()
        {             
            Restaurant restaurant = new Restaurant(RestaurantOOP.Constants.Names.RestName);
            Assert.IsTrue(restaurant.Name.Equals("SomeRest"));
        }
        [TestMethod]
        public void Visitor_Test()
        {
            Restaurant restaurant = new Restaurant(RestaurantOOP.Constants.Names.RestName);
            Assert.IsTrue(restaurant.Name.Equals("SomeRest"));
            Visitor visitorIvan = new Visitor(RestaurantOOP.Constants.Names.Ivan, restaurant);

            Assert.IsTrue(visitorIvan.Name.Equals(RestaurantOOP.Constants.Names.Ivan));
            Assert.IsTrue(visitorIvan.Restaurant == restaurant);
        }
        [TestMethod]
        public void ListOfVisitors_Test()
        {
            Restaurant restaurant = new Restaurant(RestaurantOOP.Constants.Names.RestName);

            Visitor visitorIvan = new Visitor(RestaurantOOP.Constants.Names.Ivan, restaurant);
            visitorIvan.Come();

            Visitor visitorJohn = new Visitor(RestaurantOOP.Constants.Names.John, restaurant);
            visitorJohn.Come();

            Assert.IsTrue(restaurant.ListOfVisitors.Count == 2);
            Assert.IsTrue((restaurant.ListOfVisitors.Contains(visitorIvan)) && (restaurant.ListOfVisitors.Contains(visitorJohn)));
        }
        [TestMethod]
        public void MakeWishListAndOrderList_Test()
        {
            Restaurant restaurant = new Restaurant(RestaurantOOP.Constants.Names.RestName); // создаем ресторан с именем

            Visitor visitorIvan = new Visitor(RestaurantOOP.Constants.Names.Ivan, restaurant);
            visitorIvan.MakeWishList("Marcipan", "Coffee", "Cake");
            visitorIvan.MakeOrderList();

            Assert.IsTrue(visitorIvan.WishList.Count == 3 
                          && visitorIvan.WishList.Contains("Coffee") 
                          && visitorIvan.WishList.Contains("Cake") 
                          && visitorIvan.WishList.Contains("Marcipan"));

            Assert.IsTrue(visitorIvan.OrderList.Count == 2 
                          && visitorIvan.OrderList.Contains("Coffee") 
                          && visitorIvan.OrderList.Contains("Cake") 
                          && !(visitorIvan.OrderList.Contains("Marcipan")));
        }
    }
}
