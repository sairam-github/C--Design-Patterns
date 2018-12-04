using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IProcessor
    {
        IProcessor Successor { get; set; }

        void ProcessData();
    }
}
