using IfTest;

namespace IfTestTests;

public class FakeDiscountTire : Discounts
{
    public override decimal Calculate(decimal amount, int year)
    {
        throw new NotImplementedException();
    }

    public decimal Discount(int years)
    {
        return YearlyBonus(years);
    }

    public decimal CommonCalc(decimal amount, decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
        return TierBasedDiscountCalculation(amount);
    }

    public decimal MoreComplicatedCalculation(decimal amount, decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
        return TierBasedAmountCalculation(amount);
    }
}