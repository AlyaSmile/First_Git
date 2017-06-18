using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    public static class UtilityClass
    {

        public static void PrintTime()
        { Console.WriteLine(DateTime.Now.ToShortTimeString()); }
        public static void PrintDate()
        { Console.WriteLine(DateTime.Today.ToShortDateString()); }
    }
}
