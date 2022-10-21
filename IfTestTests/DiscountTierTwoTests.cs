using IfTest;

namespace IfTestTests;

public class DiscountTierTwoTests
{
    private DiscountCommonTier dtt = new DiscountCommonTier(0.1m);

    [Test]
    public void Calculate_ZeroInputWithAnyYear_ZeroReturn()
    {
        Assert.That(dtt.Calculate(0, 0), Is.EqualTo(0));
        Assert.That(dtt.Calculate(0, 10), Is.EqualTo(0));
    }

    [Test]
    public void Calculate_PositiveInputWithZeroYear_PositiveReturn()
    {
        Assert.That(dtt.Calculate(1, 0), Is.EqualTo(0.9m));
    }

    [Test]
    public void Calculate_PositiveInputWithLessThan5Years_PositiveReturnDifferentDiscounts()
    {
        Assert.That(dtt.Calculate(1, 1), Is.EqualTo(0.891m));
        Assert.That(dtt.Calculate(1, 4), Is.EqualTo(0.864m));
    }

    [Test]
    public void Calculate_PositiveInputWithMoreThanFiveYears_PositiveReturnAreEqual()
    {
        Assert.That(dtt.Calculate(1, 5), Is.EqualTo(0.855m));
        Assert.That(dtt.Calculate(1, 6), Is.EqualTo(0.855m));
        Assert.That(dtt.Calculate(1, 10), Is.EqualTo(0.855m));
    }

    [Test]
    public void Calculate_NegativeInput_ReturnZero()
    {
        Assert.That(dtt.Calculate(-1, 0), Is.EqualTo(0));
    }
}