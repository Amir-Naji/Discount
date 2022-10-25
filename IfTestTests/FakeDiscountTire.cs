using IfTest;
using NUnit.Framework.Constraints;

namespace IfTestTests;

public class FakeDiscountTire : Discounts
{
    public override decimal Calculate(decimal amount, int year)
    {
        throw new NotImplementedException();
    }

    public decimal TierBasedAmountCalculation(decimal amount, decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
        return DiscountAmountCalculation(amount);
    }

    public decimal LoyaltyCalculation(int years, decimal amount, decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
        return LoyaltyCalculation(years, amount);
    }
}