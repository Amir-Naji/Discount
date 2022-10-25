namespace IfTest;

public class DiscountTierThree : Discounts
{
    public DiscountTierThree(decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
    }

    public override decimal Calculate(decimal amount, int years)
    {
        amount = NegativeToZero(amount);
        return TierBasedDiscountCalculation(amount) - YearlyBonus(years) * TierBasedDiscountCalculation(amount);
    }
}