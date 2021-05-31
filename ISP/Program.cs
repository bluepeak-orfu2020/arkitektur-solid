using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrderHamburger restaurant = new JoesHamburgerRestaurant();
            //IOrderHamburger restaurant = new BobbysHamburgerRestaurant();

            restaurant.OrderHamburger();
            //restaurant.OrderFries();
            //restaurant.OrderSoda();

            Console.ReadLine();
        }
    }

    interface IOrderHamburger
    {
        void OrderHamburger();
    }
    
    interface IOrderFries
    {

        void OrderFries();
    }
    
    interface IOrderSoda
    {

        void OrderSoda();
    }

    class JoesHamburgerRestaurant : IOrderHamburger, IOrderFries, IOrderSoda
    {
        public void OrderHamburger()
        {
            Console.WriteLine("OrderHamburger");
        }

        public void OrderFries()
        {
            Console.WriteLine("OrderFries");
        }

        public void OrderSoda()
        {
            Console.WriteLine("OrderSoda");
        }
    }

    class BobbysHamburgerRestaurant : IOrderHamburger
    {
        public void OrderHamburger()
        {
            Console.WriteLine("OrderHamburger from Bobby");
        }
    }
}
