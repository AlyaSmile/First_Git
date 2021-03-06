﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var разделитель = "--------------------------------------------\n";
            Console.WriteLine(разделитель + "Конструкторы класса");
            ClassCtor();
            Console.WriteLine(разделитель + "Работа со статическими полями");
            Program.StaticData();
            Console.WriteLine(разделитель + "Порядок выполнения статического и обычного конструктора");
            var B = new ClassB(); // иллюстрирует порядок выполнения обычного и статического конструкторов
            Console.WriteLine(разделитель + "Работа со статичсеким классом UtilityClass");
            UtilityClass.PrintDate();
            UtilityClass.PrintTime();
            Console.WriteLine(разделитель + "Просто использование static для импорта Math. Делаю модуль умножить на два");
            int f = -234;
            int g = StaticUsingClass.МодульНаДва(f);
            Console.WriteLine($"Входное значение {f}, выходное {g}");
            Console.ReadLine();
        }
        

        // Рассмотрение статических полей
        static void StaticData()
        {
            
           Console.WriteLine("***** Fun with Static Data *****\n");
           SavingsAccount s1 = new SavingsAccount(50);
           SavingsAccount s2 = new SavingsAccount(100);
           SavingsAccount s3 = new SavingsAccount(10000.75);

            s1.PrintSavingsAccount();
            s2.PrintSavingsAccount();
            s3.PrintSavingsAccount();
            Console.WriteLine("Поменяли ставку на 0.1, смотрим, для кого изменилось");
            SavingsAccount.currInterestRate = 0.1;
            
            s1.PrintSavingsAccount();
            s2.PrintSavingsAccount();
            s3.PrintSavingsAccount();

            // Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            // Make new object, this does NOT 'reset' the interest rate.
            SavingsAccount s4 = new SavingsAccount(4000.00);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

           
       
        }

        // ДЛя рассмотрения конструкторов
        static void ClassCtor()
        {
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("***** Fun with Class Types *****\n");
            // Allocate and configure a Car object.
            Car myCar = new Car();
            myCar.name = "Henry";
            myCar.speed = 10;
            // 

            // Speed up the car a few times and print out the
            // new state.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintInfo();
            }
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("\nСмотрим стандартный и перегруженный конструктор\n");

           Console.WriteLine("По умолчанию в конструкторе устанавливается Просто 40\n в перегруженном, специальном, скорость 60, опциональна");
            Console.WriteLine("Стандартный");
            Car TCar = new Car();
            TCar.PrintInfo();
            Console.WriteLine("Специальный с именем BMW");
            Car MCar = new Car(MyCarName: "BMW");
            MCar.PrintInfo();
            Console.WriteLine("Специальный с именем Мерин и скорость 150");
            Car GCar = new Car(MyCarName: "Мерин", MyCarSpeed: 150);
            GCar.PrintInfo();

        }
    }
}
