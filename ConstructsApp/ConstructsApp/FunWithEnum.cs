using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructsApp
{
    public class FunWithEnum
    {
        public static void FunEnum()
        {
            Console.WriteLine("**** Fun with Enums *****");
            EmpType emp = EmpType.Contractor;
           
            // Prints out "emp is a Contractor".
            Console.WriteLine("emp is a {0}.", emp.ToString());
            Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);

            Console.WriteLine("---------------------");
            EmpType e2 = EmpType.Contractor;
            // These types are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",
            Enum.GetUnderlyingType(e.GetType()));
            // Get all name/value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Now show the string name and associated value, using the D format
            // flag (see Chapter 3).
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",
                enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }

    // по умолчанию int , переделаем в byte
    enum EmpType:byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9,
        Me = 1,
    }
}
