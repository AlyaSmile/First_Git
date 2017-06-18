using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropConsoleApp
{
    class SportCar
    {
        // автосвойства
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }


    }

    class Garage
    {
        // The hidden int backing field is set to zero!
        public int NumberOfCars { get; set; } = 1;
        // The hidden Car backing field is set to null!
        public SportCar MyAuto { get; set; } = new SportCar();

        // Must use constructors to override default
        // values assigned to hidden backing fields.
        public Garage()
        {
            // Вместо такой записи можно просто установить значение по умолчанию, как и полям
            //MyAuto = new SportCar();
            //NumberOfCars = 1;
        }
        public Garage(SportCar car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
}


}
