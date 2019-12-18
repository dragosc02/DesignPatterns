using System;

namespace VisitorExample
{
    public class CheckinVisit : IVisitor
    {
        public string ProcessName => "Checkin Process";

        public bool IsValid()
        {
            var rnd = new Random();
            int random = rnd.Next(0, 100);
            return random % 2 == 0;
        }

        public void VisitElement(IElement element)
        {
            string status = IsValid() ? "passed" : "failed";
            Console.WriteLine($"{element.GetDetails()} {status} {ProcessName}");
        }
    }
}