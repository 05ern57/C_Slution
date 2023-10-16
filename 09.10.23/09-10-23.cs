
bool key = false;
int num = 0;

while (!key)
{
    Console.Write("Bana bir sayı söyle sana asal olup olmadığını söyleyeyim: ");
    string value = Console.ReadLine();
    if(!int.TryParse(value, out num)){
        Console.WriteLine("Bu bir sayı değil");
    }
    else
    {
        key = true; 
    }
}

Console.WriteLine(findPrimeNum(num));



static int findPrimeNum(int a)
{
    if(!(a <= 1)) {
        for (int i = 2; i < (a / 2); i++) { 
            if(a % i == 0)
            {
                return 0;
            }
            else { return 1; }
        }
        
    }

    return 0;
}