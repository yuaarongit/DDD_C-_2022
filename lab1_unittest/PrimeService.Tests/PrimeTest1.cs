using Prime.Service;
namespace Prime.Service.Test;

[TestFixture]
public class PrimeTest1
{

    private PrimeService __primeService = null!;
    [OneTimeSetUp]
    public void prepare()
    {
        TestContext.Progress.WriteLine("初始化 PrimeService");
        __primeService = new PrimeService();
    }
    [Test]
    public void test1IsPrime()
    {
        Console.WriteLine("測試__primeService.IsPrime(1)");
        bool result = __primeService.IsPrime(1);
        Assert.False(result, "1 不是質數");
    }
    [Test]
    public void test2IsPrime()
    {
        Console.WriteLine("測試__primeService.IsPrime(1)");
        bool result = __primeService.IsPrime(2);
        Assert.True(result, "2 是質數");
    }
}