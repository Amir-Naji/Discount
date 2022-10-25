using IfTest;

namespace IfTestTests;

public class NonCustomerDiscountTests
{
    private NonCustomerDiscount dto = new NonCustomerDiscount();

    [Test]
    public void Calculate_ZeroInputWithAnyYear_ZeroReturn()
    {
        Assert.That(dto.Calculate(0, 0), Is.EqualTo(0));
        Assert.That(dto.Calculate(0, 10), Is.EqualTo(0));
    }

    [Test]
    public void Calculate_PositiveInputWithYear_PositiveReturn()
    {
        Assert.That(dto.Calculate(1, 0), Is.EqualTo(1));
        Assert.That(dto.Calculate(1, 10), Is.EqualTo(1));
    }

    [Test]
    public void Calculate_NegativeInput_ReturnZero()
    {
        Assert.That(dto.Calculate(-1, 0), Is.EqualTo(0));
        Assert.That(dto.Calculate(-1, 10), Is.EqualTo(0));
    }
}