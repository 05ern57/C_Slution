
using System.ComponentModel.DataAnnotations;

double result = 0; //= (double)((midterm1 * .3) + (midterm2 * .3) + (midterm3 * .4));

bool validation1 = false;
int midterm1 = 0;


while (!validation1)
{


    Console.WriteLine("Ilk Vize: ");
    string userValue = Console.ReadLine();

    if (int.TryParse(userValue, out midterm1))
    {
        if (midterm1 < 100 && midterm1 > 0)
        {
            validation1 = true;
            result += midterm1 * .3;
        }
    }
}

bool validation2 = false;
int midterm2 = 0;

while (!validation2)
{


    Console.WriteLine("Ikinci vize: ");
    string uservalue = Console.ReadLine();

    if (int.TryParse(uservalue, out midterm2))
    {
        if (midterm2 < 100 && midterm2 > 0)
        {
            validation2 = true;
            result += midterm2 * .3;
        }
    }
}


bool validation3 = false;
int midterm3 = 0;

while (!validation3)
{


    Console.WriteLine("Ucuncu vize: ");
    string uservalue = Console.ReadLine();

    if (int.TryParse(uservalue, out midterm3))
    {
        if (midterm3 < 100 && midterm3 > 0)
        {
            validation3 = true;
            result += midterm3 * .3;
        }
    }
}

if (!(result < 0) && !(result > 100))
{
    if (result > 0 && result < 45) { Console.WriteLine("Dönem notunuz: F-{0}", result); }
    else if (result >= 45 && result < 55) { Console.WriteLine("Dönem notunuz: D-{0}", result); }
    else if (result >= 55 && result < 70) { Console.WriteLine("Dönem notunuz: C-{0}", result); }
    else if (result >= 70 && result < 85) { Console.WriteLine("Dönem notunuz: B-{0}", result); }
    else { Console.WriteLine("Dönem notunuz: A-{0}", result); }
}

