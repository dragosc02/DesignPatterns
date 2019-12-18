using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExample
{
    public class ObjectStructure
    {
        public List<IElement> PeopleOnBoard { get; set; }

        public void Attach(IElement element)
        {
            PeopleOnBoard.Add(element);
        }

        public void Detach(IElement element)
        {
            PeopleOnBoard.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            PeopleOnBoard.ForEach(x => x.Accept(visitor));
        }
    }
}
