using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiExample
{

    public class Printer
    {
        private readonly IPaper _paper;

        public Printer(IPaper paper)
        {
            _paper = paper;
        }

        public void PrintSomething(string something)
        {
            Console.WriteLine("You just print '{0}' on {1}", something, _paper.GetPaper());
        }
    }
}
