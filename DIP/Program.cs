using System;
using System.Collections.Generic;

namespace DIP
{
    class Program
    {
        static ICommandHandler GetHandler(string type)
        {
            if (type == "calculator")
            {
                return new CalculatorCommandHandler();
            }
            else if (type == "customer")
            {
                return new CustomerRegistry();
            }
            else
            {
                throw new Exception($"Unknown command handler: {type}");
            }
        }

        static void Main(string[] args)
        {
            ICommandHandler handler = GetHandler(args[0]);

            string line;
            while ((line = Console.ReadLine()) != "" )
            {
                string[] parts = line.Split(" ");
                List<string> data = new List<string>(parts);
                data.RemoveAt(0); // remove command
                handler.Operation(parts[0], data);
            }
        }
    }

    interface ICommandHandler
    {
        void Operation(string command, List<string> args);
    }

    class CalculatorCommandHandler : ICommandHandler
    {
        private Calculator calculator = new Calculator();

        public void Operation(string command, List<string> args)
        {
            if (command == "+")
            {
                int value1 = int.Parse(args[0]);
                int value2 = int.Parse(args[1]);
                Console.WriteLine($"Result: {calculator.Add(value1, value2)}");
            }
            else if (command == "-")
            {
                int value1 = int.Parse(args[0]);
                int value2 = int.Parse(args[1]);
                Console.WriteLine($"Result: {calculator.Sub(value1, value2)}");
            }
            else if (command == "set")
            {
                calculator.SetCounter();
                Console.WriteLine($"Counter set!");
            }
            else if (command == "inc")
            {
                calculator.IncrementCounter();
                Console.WriteLine($"Result: {calculator.GetCounterValue()}");
            }
        }
    }

    class CustomerRegistry : ICommandHandler
    {
        private List<string> registy = new List<string>() { "Adam", "Berit", "Calle" };

        public void Operation(string command, List<string> args)
        {
            if (command == "list")
            {
                Console.WriteLine($"Customers: \n");
                foreach (string customer in registy)
                {
                    Console.WriteLine($"  {customer}");
                }
            }
            else if (command == "add")
            {
                registy.Add(args[0]);
                Console.WriteLine($"Added customer: {args[0]}");
            }
        }
    }

    class Calculator
    {
        private Counter counter;
        public int Add(int i, int j)
        {
            return i + j;
        }
        
        public int Sub(int i, int j)
        {
            return i - j;
        }

        public void SetCounter()
        {
            counter = new Counter();
        }
        
        public void IncrementCounter()
        {
            counter.Increment();
        }

        public int GetCounterValue()
        {
            return counter.GetValue();
        }
    }

    class Counter
    {
        private int x = 0;

        public void Increment()
        {
            x++;
        }

        public int GetValue()
        {
            return x;
        }
    }
}
