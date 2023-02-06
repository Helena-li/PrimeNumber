using BenchmarkDotNet.Attributes;
namespace PrimeNumber.Performance.Benchmarker;

public class PrimeNumberFunctions
{
     [Benchmark()]
     public void GetPrimeUnder1000()
     {
         var primeNumbers = new PrimeFinder().GeneratePrimeNumbers(1000);
     }
     
     
     [Benchmark()]
     public void GetPrimeFrom12DigitProduct_ConvertString_NonStrictAscending()
     {
         var primeNumbers = new PrimeFinder().GeneratePrimeNumbers(1000);
         
         var products = new ProductFilter().FilterProduct(primeNumbers);
     }
     
     [Benchmark()]
     public void GetPrimeFrom12DigitProduct_Math()
     {
         var primeNumbers = new PrimeFinder().GeneratePrimeNumbers(1000);
         
         var products = new ProductFilter().FilterProductUseMathMethod(primeNumbers);
     }
     
     [Benchmark()]
     public void GetPrimeFrom12DigitProduct_ConvertString()
     {
         var primeNumbers = new PrimeFinder().GeneratePrimeNumbers(1000);
         
         var products = new ProductFilter().FilterProductUseMathMethod(primeNumbers);
     }
    
    // please make IsExpectedProductViaMath to compare the performance
    // [Benchmark()]
    // public void CheckProduct_Math()
    // {
    //     var primeNumbers = new ProductFilter().IsExpectedProductViaMath(123334444567);
    // }
    //
    // // please make IsExpectedProductCheckViaChar to compare the performance
    // [Benchmark()]
    // public void CheckProduct_String()
    // {
    //     var primeNumbers = new ProductFilter().IsExpectedProductCheckViaChar(123334444567);
    // }
}