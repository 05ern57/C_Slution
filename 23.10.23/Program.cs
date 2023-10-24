//// 2.)Yazmış olduğum tüm metodların kullanılabileceği program 


using _23._10._23;

Functions functions = new Functions(); 


while (true)
{
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
            case 1:
                Console.Write("a kenarının uzunluğunu giriniz : ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b kenarın uzunluğunu giriniz : ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine( functions.Hipotenus(a,b)); break;

            case 2:

                Console.Write("taban uznuluğunu giriniz : ");
                double @base = double.Parse(Console.ReadLine());
                Console.Write("Yüksekliği giriniz : ");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine(functions.AreaOfTriangle(@base, height)) ; break;

            case 3:
                Console.Write("Dairenin yarıçapını girniz : ");
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine(functions.AreaOfCircle(radius)); ; break;

            case 4:
                Console.Write("Kısa kenarın uzunluğunu giriniz : ");
                double @short = double.Parse(Console.ReadLine());
                Console.Write("Uzun kenarın uzunluğunu giriniz : ");
                double @long = double.Parse(Console.ReadLine());

                Console.WriteLine(functions.AreaOfRectangle(@short, @long)) ; break;
            case 5:
                Console.Write("Asal olup olmadığını kontrol etmek istediğiniz sayıyı giriniz : ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine(functions.PrimeNumCtrl(num1)); break;
            case 6:
                Console.Write("Faktöriyelini öğrenmek istediğiniz sayıyı griniz : ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(functions.Factoriel(num2)); break;
            case 7:
                Console.Write("Kontrol etmek istediğiniz Numarayı Giriniz : ");
                int num3 = int.Parse(Console.ReadLine());

                Console.WriteLine(functions.NumCtrl(num3)) ; break;
            default: Console.WriteLine("Uygun Olmayan Değer"); break;
        }

        Console.Write("Başka bir işlem yapmak istiyor musunuz? Evet ise 1 değil ise 2 yazın : ");
        int isLoopContinue;
        if (int.TryParse(Console.ReadLine(), out isLoopContinue) && isLoopContinue == 1)
        {
            Console.WriteLine("\n\n\n");
            // devam etsin diye dokunmuyorum
        }
        else { break; }

        
    }
    else
    {
        Console.WriteLine("Girilen Değer Uygun Bir Değer Değil Lütfen Tekrar Deneyiniz");
    }
}
