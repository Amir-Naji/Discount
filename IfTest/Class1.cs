using System.Runtime.CompilerServices;

namespace IfTest;

public class Class1
{
    private readonly Dictionary<int, IDiscounts> _discounts = new Dictionary<int, IDiscounts>
    {
        { 1, new NonCustomerDiscount() },
        { 2, new Discounts(0.1m) },
        { 3, new Discounts(0.3m) },
        { 4, new Discounts(0.5m) }
    };

    public decimal Calculation(decimal amount, int type, int years)
    {
        return _discounts[type].Calculate(amount, years);
    }
}