using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExample
{
    public class Passenger: IElement
    {
        public string FullName { get; set; }

        public string GetDetails()
        {
            return $"Passenger with name {FullName}";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitElement(this);
        }
    }
}
