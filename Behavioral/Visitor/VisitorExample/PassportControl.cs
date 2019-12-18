using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExample
{
    public class PassportControl: IVisitor
    {
        public string ProcessName => "Passport Control";

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
