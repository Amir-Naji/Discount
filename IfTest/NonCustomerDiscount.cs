namespace IfTest;

public class NonCustomerDiscount : Discounts
{
    public override decimal Calculate(decimal amount, int years)
    {
        return NegativeToZero(amount);
    }
}