namespace MyTests;
using MD_TestMathLib.Class;


[TestClass]

public class TipCalculatorTests
{
    [TestMethod]
    public void CalculateWeightedTip_ValidInput_ReturnsCorrectTipAmounts()
    {

        var calculator = new TipCalculator();
        var mealCosts = new Dictionary<string, decimal>
            {
                { "Alice", 50.00m },
                { "Bob", 30.00m },
                { "Charlie", 20.00m }
            };
        float tipPercentage = 15.0f;


        var tipAmounts = calculator.CalculateWeightedTip(mealCosts, tipPercentage);


        Assert.AreEqual(7.50m, tipAmounts["Alice"]);
        Assert.AreEqual(4.50m, tipAmounts["Bob"]);
        Assert.AreEqual(3.00m, tipAmounts["Charlie"]);
    }

    [TestMethod]
    public void CalculateWeightedTip_NullMealCosts_ThrowsArgumentNullException()
    {

        var calculator = new TipCalculator();
        Dictionary<string, decimal> mealCosts = null;
        float tipPercentage = 18.0f;


        Assert.ThrowsException<ArgumentNullException>(() => calculator.CalculateWeightedTip(mealCosts, tipPercentage));
    }

    [TestMethod]
    public void CalculateWeightedTip_InvalidTipPercentage_ThrowsArgumentOutOfRangeException()
    {

        var calculator = new TipCalculator();
        var mealCosts = new Dictionary<string, decimal>
            {
                { "David", 40.00m },
                { "Eve", 25.00m }
            };
        float invalidTipPercentage = -5.0f;

        Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.CalculateWeightedTip(mealCosts, invalidTipPercentage));
    }
}

