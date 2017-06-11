using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTest
{
    public class BMV : Car
    {
        public override string Color { get; set; }
        public override string Name { get;set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name}, {Color}");
        }
    }
}