using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer pri = new Printer(null);
            Capitalizer Cap = new Capitalizer(pri);

            Cap.ProcessData();
        }
    }
}
