using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    /// <summary>
    /// Здесь будет рассматриваться static
    /// </summary>
    class SavingsAccount
    {

        // Instance-level data.
        public double currBalance;

        // A static point of data.
        public static double currInterestRate = 0.04;
        

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        public void PrintSavingsAccount()
        {
            Console.WriteLine($"Баланс (currBalance) = {currBalance}, Ставка (static currInterestRate) = {currInterestRate}");
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }
        public static double GetInterestRate()
        { return currInterestRate; }


    }
}


