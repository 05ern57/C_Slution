


static int findPrimeNum(int a)
{
    int result = 0;
    
    if (!(a == 2))
    {
        for (int i = 3; i < (a / 2); i++)
        {
            if (a % i == 0)
            {
                break;
            }
            else
            {
                result++;
                break;
            }
        }
    }
    else
    {
        result++;
    }

    return result;

}
