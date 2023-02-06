namespace PrimeNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        var primeNumbers = new PrimeFinder().GeneratePrimeNumbers(1000);
        Console.WriteLine($"There're {primeNumbers.Count} primes under 1000 : ");

        var primes = string.Join("  ", primeNumbers);
        Console.WriteLine($" {primes} . ");

        // non-restricted Ascending
        var products = new ProductFilter().FilterProduct(primeNumbers);
        Console.WriteLine($"There're {products.Count} products fit the non-restricted Ascending condition : ");

        foreach (var product in products)
        {
            Console.WriteLine($"product : {product.Product} , primes: {product.PrimeNumber1} {product.PrimeNumber2} {product.PrimeNumber3} {product.PrimeNumber4} ");
        }
        
        // method 1
        var products1 = new ProductFilter().FilterProductUseMathMethod(primeNumbers);
        Console.WriteLine($"There're {products1.Count} products fit the condition - math method : ");

        foreach (var product in products1)
        {
            Console.WriteLine($"product : {product.Product} , primes: {product.PrimeNumber1} {product.PrimeNumber2} {product.PrimeNumber3} {product.PrimeNumber4} ");
        }
        
        // method 2 - better performance
        var products2 = new ProductFilter().FilterProductViaStringConvert(primeNumbers);
        Console.WriteLine($"There're {products1.Count} products fit the condition - string convert method : ");

        foreach (var product in products2)
        {
            Console.WriteLine($"product : {product.Product} , primes: {product.PrimeNumber1} {product.PrimeNumber2} {product.PrimeNumber3} {product.PrimeNumber4} ");
        }
        Console.ReadLine();
    }
}