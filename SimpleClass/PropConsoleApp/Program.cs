using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Fun with Automatic Properties *****\n");
            SportCar c = new SportCar();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            Console.WriteLine("Your car is named {0}? That's odd...",
            c.PetName);
            c.DisplayStats();

            Garage g = new Garage();
            // 0OK, prints default value of zero.
            Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
            // Если конструктр не выставляет значение по умолчанию, то будет null для MyCar и все сломается
            Console.WriteLine(g.MyAuto.PetName);
            

            Console.ReadLine();
        }
    }
}
