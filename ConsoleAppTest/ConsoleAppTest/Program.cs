using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {


        static void Main()
        {
            ProcessBytesChecked();
        }

        static void ProcessBytesChecked()
        { }



        
        static void Var()
        {
            //var Obj = null;
        }

        // преобразование типов (явное, но результат ошибочный)
        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

           byte sum = (byte)Add(b1, b2);
           Console.WriteLine("sum = {0}", sum);
           
        }


        static int Add(int x, int y)
        {
            return x + y;
        }


        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("Fantastic Games");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.ReadLine();
        }

        static void StringEquality()
        {
            // Строка - ссылочный тип, но Equals и равенства были преопределены так, что стравнивается именно ЗНАЧЕНИЕ
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Test these strings for equality.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.ReadLine();
        }

    


        static void FunType()
        {
            // Здесь я буду играться с типами

            var Dou = 123D;
            var Flo = 123F;
            var Dec = 123m;
            Console.WriteLine($"123D type: {Dou.GetType()}");
            Console.WriteLine($"123F type: {Flo.GetType()}");
            Console.WriteLine($"321m type: {Dec.GetType()}");

            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}",
            double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",
            double.NegativeInfinity);

            Console.WriteLine("Min of decimal: {0}", decimal.MinValue);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

            Console.WriteLine("=> Data type parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);

            DateTime dt = DateTime.Now;
            // dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());


            ///

            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves\t\t\t \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Adds a total of 4 blank lines (then beep again!).
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.ReadLine();
            Console.WriteLine("All finished.\n\n\n\a ");
        }


        // Еще тест - чтение параметров другим способом
        public int Main(string[] args) // Делаю временно public, чтобы не париться с точкой входа
        {
            Console.WriteLine("Привет. Это первое тестовое приложение.");
            Console.WriteLine();
            string[] argsw = Environment.GetCommandLineArgs();
            foreach (string arg in argsw)
                Console.WriteLine($"Arg {arg}");

            ShowEnviromantDetails();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Введите своё имя:");
            var name = Console.ReadLine();
            Console.WriteLine($"Введите фамилию:");
            var last_name = Console.ReadLine();
            Console.WriteLine($"введите возраст:");
            string old = Console.ReadLine();
            decimal Old = 0;
            try
            {
                 Old = Convert.ToDecimal(old);
            }
            catch (Exception)
            {

                Console.WriteLine("Ввели ерунду");
            }
            Console.WriteLine($"Привет, {last_name} {name}, тебе {Old:n2} лет");
            Console.ReadLine();
            return -1;
        }

        static void ShowEnviromantDetails()
        {
            //Console.Beep(500, 1000);
            Console.WriteLine(string.Join(Environment.NewLine + "Drive: " , Environment.GetLogicalDrives()));
            Console.WriteLine(Environment.NewLine + "Name machine: {0}", Environment.MachineName );
            Console.WriteLine("OSVersion: {0}", Environment.OSVersion .VersionString );
            Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName );
            Console.WriteLine(".NET Version: {0}", Environment.Version );
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
