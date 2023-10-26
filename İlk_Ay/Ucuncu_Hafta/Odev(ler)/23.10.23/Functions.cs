using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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


        //Üçgenin Alanı
        public double AreaOfTriangle(double @base, double height)
        {
            double area = @base * height / 2;
            return area;
        }

        // Dairenin Alanı 
        public double AreaOfCircle(double radius)
        {
            double result = Math.PI * Math.Pow(radius, 2);
            return result;
        }

        //Dikdörtgenin Alanı
        public double AreaOfRectangle(double @short, double @long)
        {
            return @short * @long;
        }

        // Asal Sayı Kontrolü
        public bool? PrimeNumCtrl(int num)
        {
            // 1'e  eşit veya küçük değilse 
            if (!(num <= 1))
            {
                // ikiye eşitse 
                if (num == 2) return true;
                // burası dersteki işlemle aynıydı fakat farklı bir şey denemek istedim.
                bool? result = null;
                for (int i = 3; i <= (num / 2); i++)
                {
                    // sayıya tam bölünüyorsa false döndürecek bölünmüyorsa 
                    result = (num % i == 0) ? false : true;
                }
                return result;

            }
            return false;
        }

        // Faktöriyel
        public int? Factoriel(int num)
        {
            // kendime not: değer döndüren fonksiyonlarda sadece if kısmıyla return yapıp bırakamazsın else kısmı olmadığında hatayla karşılaşıyorsun
            if ((num < 0)) { return null; }

            if (!(num == 0 || num == 1))
            {
                return num * this.Factoriel(num - 1);
            }
            else
            {
                return 1;
            }
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
    }
}

// ----------- Cw versiyonları-------------//

//Console.WriteLine ile yapmayı denedim... (çalışıyor)
//public void NumCtrl()
//{
//    Console.Write("Kontrol etmek istediğiniz Numarayı Giriniz : ");
//    int num = int.Parse(Console.ReadLine());

//    if (num != 0)
//    {
//        if (num < 0) { Console.WriteLine("Negatif Sayı"); } else { Console.WriteLine("Pozitif Sayı"); }
//    }
//    else { Console.WriteLine("Notr"); }

//}

//Console.WriteLine ile denedim.. (Çalışıyor)
//public void PrimeNumCtrl()
//{
//    Console.Write("Asal olup olmadığını kontrol etmek istediğiniz sayıyı giriniz : ");
//    int num = int.Parse(Console.ReadLine());

//    string isNumPrime="İşlem Gerçekleştirilemedi";
//    // 1'e  eşit veya küçük değilse 
//    if(!(num <= 1))
//    {
//        for (int i = 3; i <= (num / 2); i++)
//        {
//            if(num % i == 0)
//            {
//                isNumPrime = "Asal Değildir";
//            }
//            else
//            {
//                isNumPrime = "Asaldır";
//            }
//        }
//    }
//    else
//    {
//        isNumPrime = "Asal Değildir";
//    }
//    Console.WriteLine($"Girmiş olduğunuz değer {isNumPrime}");
//}

//Console.WriteLine ile yaptım
//public void AreaOfRectangle()
//{
//    Console.Write("Kısa kenarın uzunluğunu giriniz : ");
//    double @short = double.Parse(Console.ReadLine());
//    Console.Write("Uzun kenarın uzunluğunu giriniz : ");
//    double @long = double.Parse(Console.ReadLine());

//    Console.WriteLine( @short * @long);
//}

//Console.WriteLine ile yaptım
//public void AreaOfCircle()
//{
//    Console.Write("Dairenin yarıçapını girniz : ");
//    double radius = double.Parse(Console.ReadLine());

//    double result = Math.PI * Math.Pow(radius, 2);
//    Console.WriteLine(result);
//}

//Console.WriteLine ile yaptım
//public void AreaOfTriangle()
//{
//    Console.Write("taban uznuluğunu giriniz : ");
//    double @base = double.Parse(Console.ReadLine());
//    Console.Write("Yüksekliği giriniz : ");
//    double height = double.Parse(Console.ReadLine());

//    double area = @base * height / 2;
//    Console.WriteLine(area);
//}

//Console.WriteLine ile yaptım
//public void Hipotenus()
//{
//    Console.Write("a kenarının uzunluğunu giriniz : ");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("b kenarın uzunluğunu giriniz : ");
//    double b = double.Parse(Console.ReadLine());

//    double csquare = Math.Pow(a, 2) + Math.Pow(b, 2);
//    Console.WriteLine(Math.Sqrt(csquare));
//}



//       ################### Denemelerim #########################

// 2. Maddenin hepsini functions.cs de bir method olarak tanımlamaya çalıştım. 

//        public void AllMethods()
//        {
//            // Verbatim String literal kullanımı ile işlem sorma 
//            Console.WriteLine(@"1.Hipotenüs Hesaplama
//2.)Üçgen Alanı Hesaplama
//3.)Dairenin Alanını Hesaplama
//4.)Dikdörtgenin Alanını Hesaplama
//5.)Asal Sayı Kontrolü
//6.)Faktöriyel Hesaplama
//7.)Pozitif-Negatif Sayı Kontrolü");

//            Console.Write("Yapmak istediğiniz işlem sayı ile belirtiniz:  ");
//            int transaction;
//            if (int.TryParse(Console.ReadLine(), out transaction))
//            {


//                switch (transaction)
//                {
//                    case 1: this.Hipotenus(); break;
//                    case 2: this.AreaOfTriangle(); break;
//                    case 3: this.AreaOfCircle(); break;
//                    case 4: this.AreaOfRectangle(); break;
//                    case 5: this.PrimeNumCtrl(); break;
//                    case 6: this.Factoriel(); break;
//                    case 7: this.NumCtrl(); break;
//                    default: Console.WriteLine("Uygun Olmayan Değer"); break;
//                }
//            }
//        }



// Burda da recursive metodu cw kullanarak yapmaya çalıştım.

// Bunu Çalıştıramadım => çünkü recursive methodlar herzaman kendilerini geri döndürürler bunu Console.Writeline ile yapamayız
//public void Factoriel()
//{

//    Console.Write("Faktöriyelini öğrenmek istediğiniz sayıyı griniz : ");
//    int num = int.Parse(Console.ReadLine());

//    if ((num < 0)) { Console.WriteLine("Kesirli Negatif Sayıların Faktöriyeli Olmaz"); }

//    if (!(num == 0 || num == 1))
//    {
//        int? result = num * this.Factoriel(num - 1);
//        Console.WriteLine($"İşlemin Sonucu {result}");
//    }
//    else
//    {
//        int? result = num * this.Factoriel(num - 1);
//        Console.WriteLine($"İşlemin Sonucu {result}");
//    };

//    //Console.WriteLine(result);

//}



// Geri Döndürmeden yapma girişimi 2

// Faktöriyel Hesaplama
//public int Factoriel(int num)
//{
//    int result = num;
//    if (!(num <= 0))
//    {
//        result *= Factoriel(--num);
//    }
//    return result;

//}