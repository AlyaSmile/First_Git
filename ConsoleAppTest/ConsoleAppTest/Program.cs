using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {

        // Если запускаем с параметрами 
        public int Main(string[] args) // Делаю временно public, чтобы не париться с точкой входа
        {
            Console.WriteLine("Привет. Это первое тестовое приложение.");
            Console.WriteLine();
            foreach (string arg in args)
                Console.WriteLine($"Arg {arg}");
            Console.ReadLine();
            return -1;
        }

        // Еще тест - чтение параметров другим способом
        static int Main()
        {
            Console.WriteLine("Привет. Это первое тестовое приложение.");
            Console.WriteLine();
            string[] args = Environment.GetCommandLineArgs();
            foreach (string arg in args)
                Console.WriteLine($"Arg {arg}");
            Console.ReadLine();
            return -1;
        }


        static void CastObj()
        {
            BaseClass Obj1 = new BaseClass();
            Child Obj2 = new Child();
            Obj2.Metod1();
            Obj2.Metod2();
            ((BaseClass)Obj2).Metod1();
            ((BaseClass)Obj2).Metod2();
        }
    }


    public class BaseClass
    {
        public virtual void Metod1()
        {
            Console.WriteLine("Base");
        }

        public void Metod2()
        {
            Console.WriteLine("Base");
        }

    }

    public class Child: BaseClass
    {
        public override void Metod1()
        {
            Console.WriteLine("Child");
        }

        public void Metod2()
        {
            Console.WriteLine("Child");
        }

    }
}
