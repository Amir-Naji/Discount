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
        return PercentCalculator(years);
    }

    public decimal CommonCalc(decimal amount, decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
        return CommonCalculation(amount);
    }

    public decimal MoreComplicatedCalculation(decimal amount, decimal tierDiscountValue)
    {
        TierDiscountValue = tierDiscountValue;
        return MoreComplicatedCommonCalculation(amount);
    }
}