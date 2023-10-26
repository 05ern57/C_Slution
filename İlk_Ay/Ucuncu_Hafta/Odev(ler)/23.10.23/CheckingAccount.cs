using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._23
{
    internal class CheckingAccount : BankAccount
    {
        // constructor metodu inherit ettim 
        public CheckingAccount(string accountName, string accountIBAN) : base(accountName, accountIBAN) { }
        // 3-a.) Maddesinin yapılmış hali
        public void isCardAccessible()
        {
            Console.WriteLine("Kredi kartına bağlanabilir.");
        }
    }
}
