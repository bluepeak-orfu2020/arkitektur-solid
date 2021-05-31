using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            string line;
            while ((line = Console.ReadLine()) != "" )
            {
                string[] parts = line.Split(" ");
                if (parts[0] == "+")
                {
                    int value1 = int.Parse(parts[1]);
                    int value2 = int.Parse(parts[2]);
                    Console.WriteLine($"Result: {calculator.Add(value1, value2)}");
                }
                else if (parts[0] == "-")
                {
                    int value1 = int.Parse(parts[1]);
                    int value2 = int.Parse(parts[2]);
                    Console.WriteLine($"Result: {calculator.Sub(value1, value2)}");
                }
                else if (parts[0] == "set")
                {
                    calculator.SetCounter();
                    Console.WriteLine($"Counter set!");
                }
                else if (parts[0] == "inc")
                {
                    calculator.IncrementCounter();
                    Console.WriteLine($"Result: {calculator.GetCounterValue()}");
                }
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
