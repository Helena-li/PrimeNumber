namespace PrimeNumber;

public class PrimeFinder
{
    // get prime numbers lower than the maximum number
    public List<int> GeneratePrimeNumbers(int maximum)
    {
        if (maximum<0)
        {
            throw new ArgumentException("Maximum number for Prime finder can't be negative");
        }
        var primeNumbers = new List<int>();

        if (maximum > 2)
        {
            primeNumbers.Add(2);
            
            for (int i = 3; i <= maximum; i+=2)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }
        }

        return primeNumbers;
    }

    public bool IsPrime(int i)
    {
        for (int j = 2; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0)
            {
                return false;
            }
        }

        return true;
    }
}