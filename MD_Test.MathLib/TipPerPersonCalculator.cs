namespace MD_TestMathLib.Class;

public class TipPerPersonCalculator
{
    public decimal CalculateTipPerPerson(decimal totalPrice, int numberOfPatrons, float tipPercentage)
    {
        if (totalPrice <= 0 || numberOfPatrons <= 0 || tipPercentage < 0)
        {
            throw new ArgumentException("Invalid input. Ensure positive values for price, patrons, and tip percentage.");
        }

        decimal totalTip = totalPrice * (decimal)(tipPercentage / 100);

        decimal tipPerPerson = totalTip / numberOfPatrons;

        tipPerPerson = Math.Round(tipPerPerson, 2);

        return tipPerPerson;
    }
}



