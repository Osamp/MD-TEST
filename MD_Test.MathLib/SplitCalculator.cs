namespace MD_TestMathLib.Class;

public class SplitCalculator
{

    public decimal SplitAmount(decimal totalAmount, int numPeople)
    {
        decimal split = totalAmount / numPeople;
        return split;
    }



}


