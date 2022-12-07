namespace Prime.Service.Tests;

public class Tests
{
    [OneTimeSetUp]
    public void init() {
        //Console.WriteLine("一次性啟動"); //此參數已捕抓不到
        TestContext.Progress.WriteLine("一次性啟動");
    }
    [OneTimeTearDown]
    public void finalize() {
        //Console.WriteLine("一次性清除");
        TestContext.Progress.WriteLine("一次性清除");
    }

    [SetUp]
    public void Setup()
    {
        Console.WriteLine("準備環境");
    }
    [TearDown]
    public void StoreData()
    {
        Console.WriteLine("結束環境");
    }
    [Test]
    public void Test1()
    {
        Console.WriteLine("Test1");
        Assert.Pass();
    }
    [Test]
    [Ignore("因為還沒寫好")]
    public void Test2()
    {
        Console.WriteLine("Test2");
        Assert.Fail("Fail");
        //Assert.Pass("ok");
    }
}