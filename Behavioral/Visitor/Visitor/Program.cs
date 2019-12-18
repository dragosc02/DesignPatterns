using System;

using VisitorExample;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardingProcess = new BoardingProcess();

            boardingProcess.StartBorading();

            Console.ReadLine();
        }
    }
}
