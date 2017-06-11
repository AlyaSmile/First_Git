using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTest
{
    public class BMW : Car
    {
        public override string Color { get; set; }
        public override string Name { get;set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name}, {Color}");
        }

        static void Main()
        { }
    }
}