using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    sealed class MiniVan:Car
    {
        public void TestMethod()
        {
            // OK! Can access public members
            // of a parent within a derived type.
            Speed = 10;
            // Ошибка, нет доступа к закрытому члену!
            // Доступен только в базовом
            //currSpeed = 10;
        }
    }
}
