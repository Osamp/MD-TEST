namespace TipCalculatorTests;

using MD_TestMathLib.Class;



[TestClass]
public class TipCalculatorTests
{

    [TestMethod]
    public void CalculateTipPerPerson_ValidInput_ReturnsCorrectTip()
    {

        var calculator = new TipPerPersonCalculator();
        decimal totalPrice = 100.00m;
        int numberOfPatrons = 4;
        float tipPercentage = 15.0f;

        decimal tipPerPerson = calculator.CalculateTipPerPerson(totalPrice, numberOfPatrons, tipPercentage);

        Assert.AreEqual(3.75m, tipPerPerson);
    }

    [TestMethod]
    public void CalculateTipPerPerson_ZeroTotalPrice_ThrowsArgumentException()
    {
        var calculator = new TipPerPersonCalculator();
        decimal totalPrice = 0m;
        int numberOfPatrons = 2;
        float tipPercentage = 20.0f;

        Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTipPerPerson(totalPrice, numberOfPatrons, tipPercentage));
    }

    [TestMethod]
    public void CalculateTipPerPerson_NegativeTipPercentage_ThrowsArgumentException()
    {

        var calculator = new TipPerPersonCalculator();
        decimal totalPrice = 60.00m;
        int numberOfPatrons = 3;
        float negativeTipPercentage = -10.0f;

        Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTipPerPerson(totalPrice, numberOfPatrons, negativeTipPercentage));
    }
}

