using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            CareCenter careCenter = new CareCenter();

            // Stakeholder 1 use case
            DateTime visitor1VisitTime = new DateTime(2021, 5, 27, 9, 0, 0);
            Console.WriteLine($"Visitor 1 is allowed in: {careCenter.AcceptVisitor(visitor1VisitTime)}");

            DateTime visitor2VisitTime = new DateTime(2021, 5, 27, 20, 0, 0);
            Console.WriteLine($"Visitor 2 is allowed in: {careCenter.AcceptVisitor(visitor2VisitTime)}");

            // Stakeholder 2 use case
            DateTime callee1CallTime = new DateTime(2021, 5, 27, 10, 0, 0);
            Console.WriteLine($"Callee 1 is allowed in: {careCenter.AcceptPhoneCall(callee1CallTime)}");

            DateTime callee2CallTime = new DateTime(2021, 5, 27, 19, 0, 0);
            Console.WriteLine($"Callee 2 is allowed in: {careCenter.AcceptPhoneCall(callee2CallTime)}");

            Console.ReadKey();
        }
    }
}
