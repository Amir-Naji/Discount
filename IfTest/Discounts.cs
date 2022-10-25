using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DiscountTierTwoTests")]
namespace IfTest;

public class Discounts : IDiscounts
{
    private const int MaxYearDiscountToCalculate = 5;
    private const int Percent = 100;

    private readonly decimal _tierDiscountValue;

    public Discounts(decimal tierDiscountValue)
    {
        _tierDiscountValue = tierDiscountValue;
    }

    public decimal Calculate(decimal amount, int years)
    {
        amount = amount.NegativeToZero();
        return DiscountAmountCalculation(amount) - LoyaltyCalculation(years, amount);
    }

    private decimal LoyaltyCalculation(int year, decimal amount)
    {
        return YearlyBonus(year) * DiscountAmountCalculation(amount);
    }

    private decimal DiscountAmountCalculation(decimal amount)
    {
        return amount - TierBasedDiscountCalculation(amount);
    }

    private static decimal YearlyBonus(int years)
    {
        years = years.NegativeToZero();

        return years > MaxYearDiscountToCalculate
            ? (decimal)MaxYearDiscountToCalculate / Percent
            : (decimal)years / Percent;
    }

    private decimal TierBasedDiscountCalculation(decimal amount)
    {
        return _tierDiscountValue * amount;
    }
}