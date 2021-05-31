using System;
using System.Collections.Generic;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            //Car car = new OldCar();
            //Car car = new DesignCar();
            //Car car = new ReallyOldCar();
            //Car car = new WeirdCar();

            car.Drive();
            car.Stop();
            car.AutoPark();
            car.SetColor("yellow");
            car.PrintColor();
            Dictionary<string, string> stats = car.FetchStats();
            Console.WriteLine($"Mileage: {stats["mileage"]}");
            car.ComputeMetaData();
            Console.WriteLine($"Can sign insurance: {car.CanSignInsurance()}");

            Console.ReadLine();
        }
    }

    class Car
    {
        protected string color;
        protected int? age = null;

        public void Drive()
        {
            Console.WriteLine("Drive");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public virtual void AutoPark()
        {
            Console.WriteLine("AutoPark");
        }

        public virtual void SetColor(string color)
        {
            this.color = color;
        }

        public void PrintColor()
        {
            Console.WriteLine($"The car is {color}");
        }

        public virtual Dictionary<string, string> FetchStats()
        {
            return new Dictionary<string, string>() { { "mileage", "123" } };
        }

        public bool CanSignInsurance()
        {
            Console.WriteLine($"age is: {age}");
            return age < 10;
        }

        public virtual void ComputeMetaData()
        {
            age = 5;
        }
    }

    class OldCar : Car
    {
        /*
         Throws exception that the base class does not
         */
        public override void AutoPark()
        {
            throw new Exception("Function not supported");
        }
    }

    class DesignCar : Car
    {
        /*
         Applies stricter input validation than the base class
         */
        public override void SetColor(string color)
        {
            if (color != "red" && color != "blue")
            {
                color = "red";
            }
            this.color = color;
        }
    }

    class ReallyOldCar : Car
    {
        /*
         Applies looser restrictions on the return value
         */
        public override Dictionary<string, string> FetchStats()
        {
            return null;
        }
    }

    class WeirdCar : Car
    {
        /*
         Does not apply the same side effects as the base class
         */
        public override void ComputeMetaData()
        {
            // Do stuff
        }
    }
}
