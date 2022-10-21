using System.Runtime.CompilerServices;

namespace IfTest;

public class Class1
{
    public decimal Calculation(decimal amount, int type, int years)
    {
        var discounts = new Dictionary<int, Discounts>
        {
            { 1, new DiscountTierOne() },
            { 2, new DiscountCommonTier(0.1m) },
            { 3, new DiscountTierThree(0.7m) },
            { 4, new DiscountCommonTier(0.5m) }
        };

        return discounts[type].Calculate(amount, years);
    }
}