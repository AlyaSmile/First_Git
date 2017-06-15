using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCat();


        }


        // 1. 
        /// <summary>
        /// Применение разных способов к сравнению
        /// 1. ref1 == ref2: в этом случае вернет true только тогда, когда ссылки на объекты одинаковые
        /// 2. ref1.Equals(ref2): так как тут переопределено, то сравнение идет только по полю класса
        /// 3. ReferenceEquals(ref1, ref2): сравнивает ссылки на объекты
        /// </summary>
        static void СравнениеОбъектов()
        {
            ClassA ref1 = new ClassA();
            ref1.value = 7;

            ClassA ref2 = new ClassA();
            ref2.value = 7;

            Console.WriteLine(ref1 == ref2);
            Console.WriteLine(ref1.Equals(ref2));
            Console.WriteLine(ReferenceEquals(ref1, ref2));
            Console.ReadLine();
        }


        static void TryCat()
        {
            Int32 i = 1, j = 0;
            try
            {
                i++;
                i += i / j;
            }
            catch (DivideByZeroException)
            {
                i--;
            }
            catch (Exception)
            {
                i = 0;
            }
            catch
            {
                i = -1;
            }
            finally
            {
                i *= i;
            }

            Console.WriteLine(i);
            Console.ReadLine();


        }
    }


    class ClassA
    {
        public override bool Equals(object obj)
        {
            ClassA that = (ClassA)obj;
            return that.value == this.value;
        }
        public int value = 6;
    }

    class Task2
    {
        delegate int Function();

        public static void Deleg()
        {
            List<Function> funcs = new List<Function>();
            int[] arr = { 4, 3, 2, 1 };
            foreach (int item in arr)
            {
                funcs.Add(() => item);
            }
            foreach (Function f in funcs)
            {
                Console.WriteLine(f());
            }
            Console.ReadLine();
        }
    }
}
