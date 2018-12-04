using System;

namespace ChainOfResponsibility
{
    public class Capitalizer : IProcessor
    {
        public Capitalizer(IProcessor processor)
        {
            Successor = processor;
        }

        public IProcessor Successor { get; set; }

        public void ProcessData()
        {
            Console.WriteLine($"Processing {this.ToString()}");

            if (Successor != null)
            {
                Successor.ProcessData();
            }
        }
    }
}