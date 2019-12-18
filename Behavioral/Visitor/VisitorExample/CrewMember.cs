using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExample
{
    public class CrewMember: IElement
    {
        public string Role { get; set; }

        public string FullName { get; set; }

        public string GetDetails()
        {
            return $"Crew Member - {Role} - {FullName}";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitElement(this);
        }
    }
}
