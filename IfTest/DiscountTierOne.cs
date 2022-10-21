namespace IfTest;

public class DiscountTierOne : Discounts
{
    public override decimal Calculate(decimal amount, int years)
    {
        return NegativeToZero(amount);
    }
}