using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExample
{
    public class BoardingProcess
    {
        private List<IVisitor> _visitorsList;

        private List<IElement> elements;

        private ObjectStructure _objectStructure;

        public BoardingProcess()
        {
            InitializeVisitorList();
            InitializeElementList();
            _objectStructure = new ObjectStructure();
            _objectStructure.PeopleOnBoard = elements;
        }

        public void StartBorading()
        {
            Console.WriteLine("Start boarding process");

            _visitorsList.ForEach(v => _objectStructure.Accept(v));

            Console.WriteLine("Complete boarding process");
        }

        private void InitializeVisitorList()
        {
            _visitorsList = new List<IVisitor>
            {
                new CheckinVisit(),
                new PassportControl(),
                new BoardingVisit()
            };
        }

        private void InitializeElementList()
        {
            elements = new List<IElement>
            {
                new CrewMember
                {
                    FullName = "John",
                    Role = "Pilot"
                },
                new CrewMember
                {
                    FullName = "David",
                    Role = "Pilot"
                },
                new Passenger{ FullName = "Dragos"},
                new Passenger{ FullName = "Ion"},
                new Passenger{ FullName = "Vasile"},
                new Passenger{ FullName = "Mircea"},
                new Passenger{ FullName = "Maria"},
                new Passenger{ FullName = "Andreea"}
            };
        }
    }
}
