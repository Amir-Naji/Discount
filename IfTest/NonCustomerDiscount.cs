namespace IfTest;

public class NonCustomerDiscount : IDiscounts
{
    public decimal Calculate(decimal amount, int years)
    {
        //return NegativeToZero(amount);
        return 0;
    }
}