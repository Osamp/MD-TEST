namespace MD_TestMathLib.Class;


public class TipCalculator
{
    public Dictionary<string, decimal> CalculateWeightedTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        if (mealCosts == null)
            throw new ArgumentNullException(nameof(mealCosts), "Meal costs dictionary cannot be null.");

        if (tipPercentage < 0 || tipPercentage > 100)
            throw new ArgumentOutOfRangeException(nameof(tipPercentage), "Tip percentage must be between 0 and 100.");

        var tipAmounts = new Dictionary<string, decimal>();

        foreach (var kvp in mealCosts)
        {
            string name = kvp.Key;
            decimal cost = kvp.Value;

            decimal tipAmount = cost * (decimal)(tipPercentage / 100);

            tipAmount = Math.Round(tipAmount, 2);

            tipAmounts[name] = tipAmount;
        }

        return tipAmounts;
    }
}

