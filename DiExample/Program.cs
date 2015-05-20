using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new IOCContainer();
            container.Register<Printer, Printer>();
            container.Register<IPaper, WhitePaper>();
            //container.Register<IPaper,WhitePaper>();


            var printer = container.Resolve<Printer>();

            printer.PrintSomething("dasdas");

            Console.ReadLine();
        }
    }

  
}
