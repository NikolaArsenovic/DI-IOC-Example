using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiExample
{
    public interface IPaper
    {
        string GetPaper();
    }

    public class YellowPaper : IPaper
    {
        public string GetPaper()
        {
            return "Yellow Paper";
        }
    }

    public class WhitePaper : IPaper
    {

        public string GetPaper()
        {
            return "White Paper";
        }
    }

}
