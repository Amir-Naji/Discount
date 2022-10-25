namespace IfTest;

public abstract class Discounts
{
    protected const int MaxYearDiscountToCalculate = 5;
    protected const int Percent = 100;

    protected decimal TierDiscountValue;

    public abstract decimal Calculate(decimal amount, int years);

    protected decimal NegativeToZero(decimal amount)
    {
        return (amount < 0) ? 0 : amount;
    }

    protected decimal TierBasedDiscountCalculation(decimal amount)
    {
        return TierDiscountValue * amount;
    }

    protected decimal TierBasedAmountCalculation(decimal amount)
    {
        return amount - TierBasedDiscountCalculation(amount);
    }

    protected decimal YearlyBonus(int years)
    {
        years = NegativeToZero(years);

        return years > MaxYearDiscountToCalculate 
            ? (decimal)MaxYearDiscountToCalculate / Percent 
            : (decimal)years / Percent;
    }

    private static int NegativeToZero(int input)
    {
        return (input < 0) ? 0 : input;
    }
}