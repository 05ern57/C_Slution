using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _23._10._23
{

    // 1.) Functions Class'ı ve içinde istenen metotları 
    // overload edilen metodlar 2.işlem için
    internal class Functions
    {
        // Hipotenüsün Alanı
        public double Hipotenus(double a, double b)
        {
            double csquare = Math.Pow(a, 2) + Math.Pow(b, 2);
            return Math.Sqrt(csquare);
        }

        public void Hipotenus()
        {
            Console.Write("a kenarının uzunluğunu giriniz : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b kenarın uzunluğunu giriniz : ");
            double b = double.Parse(Console.ReadLine());

            double csquare = Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.WriteLine(Math.Sqrt(csquare));
        }

        //Üçgenin Alanı
        public double AreaOfTriangle(double @base, double height)
        {
            double area = @base * height / 2;
            return area;
        }

        public void AreaOfTriangle()
        {
            Console.Write("taban uznuluğunu giriniz : ");
            double @base = double.Parse(Console.ReadLine());
            Console.Write("Yüksekliği giriniz : ");
            double height = double.Parse(Console.ReadLine());

            double area = @base * height / 2;
            Console.WriteLine(area);
        }

        // Dairenin Alanı 
        public double AreaOfCircle(double radius)
        {
            double result = Math.PI * Math.Pow(radius, 2);
            return result;
        }

        public void AreaOfCircle()
        {
            Console.Write("Dairenin yarıçapını girniz : ");
            double radius = double.Parse(Console.ReadLine());

            double result = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(result);
        }

        //Dikdörtgenin Alanı
        public double AreaOfRectangle(double @short, double @long)
        {
            return @short * @long;
        }

        public void AreaOfRectangle()
        {
            Console.Write("Kısa kenarın uzunluğunu giriniz : ");
            double @short = double.Parse(Console.ReadLine());
            Console.Write("Uzun kenarın uzunluğunu giriniz : ");
            double @long = double.Parse(Console.ReadLine());

            Console.WriteLine( @short * @long);
        }

        // Asal Sayı Kontrolü
        public bool PrimeNumCtrl(int num)
        {
            // 1'e  eşit veya küçük değilse 
            if (!(num <= 1))
            {
                // ikiye eşitse 
                if (num == 2) return true;
                // burası dersteki işlemle aynı
                for (int i = 3; i < (num / 2); i++)
                {
                    // sayıya tam bölünüyorsa false döndürecek bölünmüyorsa true
                    return (num % i == 0) ? false : true;
                }
            }
            return false;
        }

        public void PrimeNumCtrl()
        {

            Console.Write("Asal olup olmadığını kontrol etmek istediğiniz sayıyı giriniz : ");
            int num = int.Parse(Console.ReadLine());

            // 1'e  eşit veya küçük değilse 
            if (!(num <= 1))
            {
                // ikiye eşitse 
                if (num == 2) Console.WriteLine("Sayı Asal Sayıdır"); return;
                // burası dersteki işlemle aynı
                for (int i = 3; i < (num / 2); i++)
                {
                    // sayıya tam bölünüyorsa false döndürecek bölünmüyorsa true
                    if (num % i == 0) { Console.WriteLine("Sayı Asal Sayı Değildir"); } 
                    else { Console.WriteLine("Sayı Asal Sayıdır");}
                }
            }
            Console.WriteLine("Sayı Asal Sayı Değildir");
        }

        // Faktöriyel Hesaplama
        public short Factoriel(short num)
        {
            short result = num;
            if (!(num <= 0))
            {
                result *= Factoriel(--num);
            }
            return result;

        }
        // Bunu Çalıştıramadım
        public void Factoriel()
        {

            Console.Write("Faktöriyelini öğrenmek istediğiniz sayıyı griniz : ");
            int num = int.Parse(Console.ReadLine());

            
            int result = num;
            for(int i =(num -1); num > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);

        }

        // Pozitif-Negatif kontrolü
        public string NumCtrl(int num)
        {
            

            if (num != 0)
            {
                return (num < 0) ? "Negatif" : "Pozitif";
            }
            else { return "Notr"; }
        }

        public void NumCtrl()
        {
            Console.Write("Kontrol etmek istediğiniz Numarayı Giriniz : ");
            int num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                if (num < 0) { Console.WriteLine("Negatif Sayı"); } else { Console.WriteLine("Pozitif Sayı"); }
            }
            else { Console.WriteLine("Notr"); }

        }

        public void AllMethods()
        {
            // Verbatim String literal kullanımı ile işlem sorma 
            Console.WriteLine(@"1.Hipotenüs Hesaplama
2.)Üçgen Alanı Hesaplama
3.)Dairenin Alanını Hesaplama
4.)Dikdörtgenin Alanını Hesaplama
5.)Asal Sayı Kontrolü
6.)Faktöriyel Hesaplama
7.)Pozitif-Negatif Sayı Kontrolü");

            Console.Write("Yapmak istediğiniz işlem sayı ile belirtiniz:  ");
            int transaction;
            if (int.TryParse(Console.ReadLine(), out transaction))
            {


                switch (transaction)
                {
                    case 1: this.Hipotenus(); break;
                    case 2: this.AreaOfTriangle(); break;
                    case 3: this.AreaOfCircle(); break;
                    case 4: this.AreaOfRectangle(); break;
                    case 5: this.PrimeNumCtrl(); break;
                    case 6: this.Factoriel(); break;
                    case 7: this.NumCtrl(); break;
                    default: Console.WriteLine("Uygun Olmayan Değer"); break;
                }
            }
        }

    }
}
