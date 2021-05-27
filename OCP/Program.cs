using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle() { Radius = 5 };
            Rectangle r1 = new Rectangle() { Width = 4, Height = 5 };
            Triangle t1 = new Triangle() { Width = 3, Height = 7 };
            Geometry g = new Geometry();

            Console.WriteLine($"C1 area: {g.CalculateArea(c1)}");
            Console.WriteLine($"R1 area: {g.CalculateArea(r1)}");
            Console.WriteLine($"T1 area: {g.CalculateArea(t1)}");
        }
    }
}
