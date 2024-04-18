namespace MyTests;

using MD_TestMathLib.Class;



[TestClass]
public class SplitCalculatorTests
{
    [TestMethod]
    public void TestSplitAmount_TwoPeople()
    {
        var calculator = new SplitCalculator();
        decimal totalAmount = 100.00m;
        int numPeople = 2;

        decimal split = calculator.SplitAmount(totalAmount, numPeople);

        Assert.AreEqual(50.00m, split);
    }

    [TestMethod]
    public void TestSplitAmount_FivePeople()
    {

        var calculator = new SplitCalculator();
        decimal totalAmount = 150.00m;
        int numPeople = 5;

        decimal split = calculator.SplitAmount(totalAmount, numPeople);

        Assert.AreEqual(30.00m, split);
    }

    [TestMethod]
    public void TestSplitAmount_TenPeople()
    {
        var calculator = new SplitCalculator();
        decimal totalAmount = 200.00m;
        int numPeople = 10;

        decimal split = calculator.SplitAmount(totalAmount, numPeople);

        Assert.AreEqual(20.00m, split);
    }

}

