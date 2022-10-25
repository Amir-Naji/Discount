using System.Runtime.CompilerServices;

namespace IfTest;

public class Class1
{
    private readonly Dictionary<int, Discounts> _discounts = new Dictionary<int, Discounts>
    {
        { 1, new NonCustomerDiscount() },
        { 2, new DiscountTier(0.1m) },
        { 3, new DiscountTier(0.3m) },
        { 4, new DiscountTier(0.5m) }
    };

    public decimal Calculation(decimal amount, int type, int years)
    {
        return _discounts[type].Calculate(amount, years);
    }
}