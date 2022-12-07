using Prime.Service;
namespace Prime.Service.Test;

[TestFixture]
public class PrimeTest1
{
    
    private PrimeService __primeService = null!;
    [SetUp]
    public void prepare(){
         Console.WriteLine("初始化 PrimeService"); 
        __primeService = new PrimeService();
    }
    [Test]
    public void test1IsPrime()
    {
        Console.WriteLine("開始測試PrimeService");        
        bool result = __primeService.IsPrime(1);
        Assert.False(result, "1 不是質數");

    }
}