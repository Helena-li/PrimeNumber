using Xunit;

namespace PrimeNumber.Tests;

public class UnitTest1
{
    [Fact]
    public void GetPrimeNumber_under1000()
    {
        var primeNumbers = new PrimeFinder().GeneratePrimeNumbers(1000);

        var actual = primeNumbers.Count;

        var expected = 168;
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CheckPrimeNumber_2()
    {
        var isPrime = new PrimeFinder().IsPrime(2);

        Assert.True(isPrime);
    }

    [Fact]
    public void CheckPrimeNumber_9()
    {
        var isPrime = new PrimeFinder().IsPrime(9);

        Assert.False(isPrime);
    }
    
    [Fact]
    public void GetPrimeNumber_productOf4Num_12dig_ascend_convertString()
    {
        var primeNumbers = new PrimeFinder().GeneratePrimeNumbers(1000);
        var products = new ProductFilter().FilterProductViaStringConvert(primeNumbers);

        Assert.NotEmpty(products);
        Assert.Equal(products[0].Product, (long)products[0].PrimeNumber1*products[0].PrimeNumber2*products[0].PrimeNumber3*products[0].PrimeNumber4);
        Assert.Equal(12, products[0].Product.ToString().Length);
    }
    
    [Fact]
    public void GetPrimeNumber_productOf4Num_12dig_ascend_math()
    {
        var primeNumbers = new PrimeFinder().GeneratePrimeNumbers(1000);
        var products = new ProductFilter().FilterProductUseMathMethod(primeNumbers);

        Assert.NotEmpty(products);
        Assert.Equal(products[0].Product, (long)products[0].PrimeNumber1*products[0].PrimeNumber2*products[0].PrimeNumber3*products[0].PrimeNumber4);
        Assert.Equal(12, products[0].Product.ToString().Length);
    }
}