using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTest
{
    public abstract class Car
    {
        public abstract string Color
        {
            get;
            set;
        }

        public abstract string Name
        {
            get;
            set;
        }

        public abstract void PrintInfo();

    }
}