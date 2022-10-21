namespace IfTest;

public class DiscountCommonTier : Discounts
{
    public DiscountCommonTier(decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
    }

    public override decimal Calculate(decimal amount, int years)
    {
        amount = NegativeToZero(amount);
        return MoreComplicatedCommonCalculation(amount) - PercentCalculator(years) * MoreComplicatedCommonCalculation(amount);
    }
}