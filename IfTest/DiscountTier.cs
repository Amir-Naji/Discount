namespace IfTest;

public class DiscountTier : Discounts
{
    public DiscountTier(decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
    }

    public override decimal Calculate(decimal amount, int years)
    {
        amount = NegativeToZero(amount);
        return DiscountAmountCalculation(amount) - LoyaltyCalculation(years, amount);
    }
}