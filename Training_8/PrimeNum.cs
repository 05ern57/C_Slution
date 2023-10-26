using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_8
{
    internal class PrimeNum
    {
        public void PrimeNumCtrl()
        {
            while (true)
            {
                Console.Write(@"Please write your number that you want to check: ");

                if (int.TryParse(Console.ReadLine(), out int input) && input > 0)
                {
                    if (primeChecker(input))
                    {
                        Console.WriteLine($"Yes thats correct {input} is a Prime Number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"No thats incorrect {input} is NOT a Prime Number but...");
                        Console.WriteLine($"the closest prime number is {this.FindClosestPrimeNum(input)}");

                        break;
                    }
                }
                else { Console.WriteLine("pls write a number greater than zero, now Lets try again...\n"); }
            }
        }

        // burayı yapıcan 
        public int FindClosestPrimeNum(int num)
        {
            int ceiledPrimeNum;
            int floatedPrimeNum;

            for (int i = 1; true; i++)
            {
                if (primeChecker(num+i))
                {
                    ceiledPrimeNum = (num + i);
                    break;
                }
            }

            for (int i = -1; true; i--)
            {
                if (primeChecker(num + i) )
                {
                    
                    floatedPrimeNum = (num + i);
                    break;
                }

                if (num + i <= 1)
                {
                    floatedPrimeNum = ceiledPrimeNum + 1; break;
                };
            }

            return Math.Abs(ceiledPrimeNum - num) < Math.Abs( floatedPrimeNum - num) ? ceiledPrimeNum : floatedPrimeNum;

        }

        public bool primeChecker(int input)
        {
            if (input == 2)
            {
                return true;
            }
            else if (input % 2 == 0)
            {
                return false;
            }

            bool result = false;
            //burada bütün ihtimalleri denemiyorsun direk tek değerde oldu diyip döngüden çıkıyorsun burayı düzelmen lazım
            for (int i = 3; i <= (input / 2); i += 2)
            {
                if (!(input % i == 0))
                {

                    result = true;
                }else
                {
                    result = false;
                    break;
                }
                
            }
            return result;
        }


        //public void PrimeNumCtrl()
        //{
        //    while (true)
        //    {
        //        Console.Write(@"Please write your number that you want to check: ");

        //        if (int.TryParse(Console.ReadLine(), out int input) && input > 0)
        //        {
        //            if (input == 2)
        //            {
        //                //true
        //                Console.WriteLine($"Yes thats correct {input} is a Prime Number");
        //                break;
        //            }
        //            else if (input % 2 == 0)
        //            {
        //                //false
        //                Console.WriteLine($"No thats incorrect {input} is NOT a Prime Number");
        //                break;
        //            }

        //            //for (int i = 3; i <= (input / 2); i += 2)
        //            //{
        //            //    if (!(input % i == 0))
        //            //    {

        //            //        //true
        //            //        Console.WriteLine($"Yes thats correct {input} is a Prime Number");
        //            //        break;
        //            //    }
        //            //    else
        //            //    {
        //            //        //false
        //            //        Console.WriteLine($"No thats incorrect {input} is NOT a Prime Number");
        //            //        break;
        //            //    }
        //            //}
        //            primeChecker(input);
        //            break;
        //        }else { Console.WriteLine("pls write a number greater than zero, now ...\n\n"); }
        //    }
        //}
    }
}
