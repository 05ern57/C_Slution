using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._23
{
    internal class SavingsAccount : BankAccount
    {
        // constructor metodu inherit ettim               // burada da değişkenleri constructor içindeki değişkenlerle birleştirdim yani 
        public SavingsAccount( string accountIBAN , string accountName) : base(accountIBAN : accountIBAN, accountName: accountName) { }

        // 3-d-ii) bu maddeyi anlamadım bakiye eklemedik ki faiz hesaplayabilelim ama böyle yapmaya karar verdim
        public float BalanceWithInterestRate(float currentBalance, double interestRate)
        {
            return (float)(currentBalance * ((float)1 + interestRate));
        }
    }
}
