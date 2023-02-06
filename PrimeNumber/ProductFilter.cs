using PrimeNumber.Models;

namespace PrimeNumber;

public class ProductFilter
{
     public List<PrimeResponse> FilterProductViaStringConvert(List<int> primeList)
    {
        // since 100*1000*1000*1000 is 12 digits, remove prime <100
        while (primeList[0]<100)
        {
            primeList.Remove(primeList[0]);
        }
        var listLength = primeList.Count;
        var result = new List<PrimeResponse>();
        
        for (var i = 0; i < listLength; i++)
        {
            // since 4 diff numbers, j=i+1 in the loop
            for (var j = i+1; j < listLength; j++)
            {
                for (var k = j+1; k < listLength; k++)
                {
                    for (var l = k+1; l < listLength; l++)
                    {
                        var productNumber = (long)primeList[i] * primeList[j] * primeList[k] * primeList[l];
                        
                        if (IsExpectedProductCheckViaChar(productNumber))
                        {
                            result.Add(new PrimeResponse()
                            {
                                Product = productNumber,
                                PrimeNumber1 = primeList[i],
                                PrimeNumber2 = primeList[j],
                                PrimeNumber3 = primeList[k],
                                PrimeNumber4 = primeList[l]
                            });
                        }
                    }
                }
            }
        }

        return result;
    }
     
     private bool IsExpectedProductCheckViaChar(long productNumber)
    {
        var isExpected = false;
        if (productNumber < Math.Pow(10, 11)) return false;
        var productString = productNumber.ToString();
        for (var i = 0; i < 11; i++)
        {
            var d1 = productString[i + 1];
            var d2 = productString[i];
            if (d1 - d2 == 0 || d1 - d2  == 1)
            {
                isExpected = true;
            }
            else
            {
                return false;
            }
        }

        return isExpected;
    }

    public List<PrimeResponse> FilterProductUseMathMethod(List<int> primeList)
    {
        while (primeList[0]<100)
        {
            primeList.Remove(primeList[0]);
        }
        var listLength = primeList.Count;
        var result = new List<PrimeResponse>();
        
        for (var i = 0; i < listLength; i++)
        {
            for (var j = i+1; j < listLength; j++)
            {
                for (var k = j+1; k < listLength; k++)
                {
                    for (var l = k+1; l < listLength; l++)
                    {
                        var productNumber = (long)primeList[i] * primeList[j] * primeList[k] * primeList[l];
                       
                        if (IsExpectedProductViaMath(productNumber))
                        {
                            result.Add(new PrimeResponse()
                            {
                                Product = productNumber,
                                PrimeNumber1 = primeList[i],
                                PrimeNumber2 = primeList[j],
                                PrimeNumber3 = primeList[k],
                                PrimeNumber4 = primeList[l]
                            });
                        }
                    }
                }
            }
        }

        return result;
    }

    private bool IsExpectedProductViaMath(long productNumber)
    {
        var isExpected = false;
        if (productNumber < 100000000000) return false;
        for (var i = 11; i >0; i--)
        {
            var digit1 = (int)(productNumber / Math.Pow(10, i));
             productNumber = productNumber % (long)Math.Pow(10, i) ;
            var digit2 = (int)((productNumber) / Math.Pow(10, i-1));
            if (digit1 == digit2 || digit1 + 1 == digit2)
            {
                isExpected = true;
            }
            else
            {
                return false;
            }
        }

        return isExpected;
    }

    #region init version

    /// <summary>
    /// Old method to get non-restricted ascending 12 digit number - this one got worst performance
    /// </summary>
    /// <param name="primeList"></param>
    /// <returns></returns>
    public List<PrimeResponse> FilterProduct(List<int> primeList)
    {
        // since 100*1000*1000*1000 is 12 digits, remove prime <100
        while (primeList[0]<100)
        {
            primeList.Remove(primeList[0]);
        }
        var listLength = primeList.Count;
        var result = new List<PrimeResponse>();
        
        for (var i = 0; i < listLength; i++)
        {
            // since 4 diff numbers, j=i+1 in the loop
            for (var j = i+1; j < listLength; j++)
            {
                for (var k = j+1; k < listLength; k++)
                {
                    for (var l = k+1; l < listLength; l++)
                    {
                        var productNumber = (long)primeList[i] * primeList[j] * primeList[k] * primeList[l];
                        var productString = productNumber.ToString().ToCharArray();
                        
                        var isProduct = false;
                        if (productString.Length == 12)
                        {
                            for (var m = 0; m < 11; m++)
                            {
                                if (productString[m] <= productString[m+1] )
                                {
                                    isProduct = true;
                                }
                                else
                                {
                                    isProduct = false;
                                    break;
                                }
                            }

                            if (isProduct)
                            {
                                result.Add(new PrimeResponse()
                                {
                                    Product = productNumber,
                                    PrimeNumber1 = primeList[i],
                                    PrimeNumber2 = primeList[j],
                                    PrimeNumber3 = primeList[k],
                                    PrimeNumber4 = primeList[l]
                                });
                            }
                            
                        }
                    }
                }
            }
        }

        return result;
    }
    
    #endregion
}