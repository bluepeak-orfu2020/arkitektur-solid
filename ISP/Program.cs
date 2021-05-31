using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            //IHamburgerRestaurant restaurant = new JoesHamburgerRestaurant();
            IHamburgerRestaurant restaurant = new BobbysHamburgerRestaurant();

            restaurant.OrderHamburger();
            restaurant.OrderFries();
            restaurant.OrderSoda();

            Console.ReadLine();
        }
    }

    interface IHamburgerRestaurant
    {
        void OrderHamburger();

        void OrderFries();

        void OrderSoda();
    }

    class JoesHamburgerRestaurant : IHamburgerRestaurant
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

    class BobbysHamburgerRestaurant : IHamburgerRestaurant
    {
        public void OrderFries()
        {
            throw new NotImplementedException();
        }

        public void OrderHamburger()
        {
            Console.WriteLine("OrderHamburger from Bobby");
        }

        public void OrderSoda()
        {
            throw new NotImplementedException();
        }
    }
}
