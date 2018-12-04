using System;

namespace ChainOfResponsibility
{
    public class Printer : IProcessor
    {
        public Printer(IProcessor processor)
        {
            Successor = processor;
        }

        public IProcessor Successor { get; set; }

        public void ProcessData()
        {
            Console.WriteLine($"Processing {this.ToString()}");
        }
    }
}