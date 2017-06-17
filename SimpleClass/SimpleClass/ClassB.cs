using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class ClassB
    {
        static ClassB()
        {
            Console.WriteLine("I am static ctor!");
        }
        public ClassB()
        {
            Console.WriteLine("I am classic ctor!");
        }

    }
}
