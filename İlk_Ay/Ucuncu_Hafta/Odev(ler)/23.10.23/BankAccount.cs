using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._23
{
    internal class BankAccount
    {
        public string accountName;
        public string accountIBAN;

        // overload yapmak yerine default değerlerle eşleme yaptım.
        public BankAccount(string accountName = "Tanımlanmamış", string accountIBAN = "Tanımlanmamış") { 
            this.accountName = accountName;
            this.accountIBAN = accountIBAN;
        }
    }
}
