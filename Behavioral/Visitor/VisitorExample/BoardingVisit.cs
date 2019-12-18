using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExample
{
    public class BoardingVisit: IVisitor
    {
        public string ProcessName => "Final Boarding Process";

        public bool IsValid()
        {
            return true;
        }

        public void VisitElement(IElement element)
        {
            string status = IsValid() ? "passed" : "failed";
            Console.WriteLine($"{element.GetDetails()} {status} {ProcessName}");
        }
    }
}
