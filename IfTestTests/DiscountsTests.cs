using IfTest;

namespace IfTestTests;

public class DiscountsTests
{
    private FakeDiscountTire fdt = new FakeDiscountTire();
    private const decimal TierDiscountValue = 0.7m;

    [Test]
    public void PercentCalculator_ZeroYear_ZeroPercent()
    {
        Assert.That(fdt.Discount(0), Is.EqualTo(0));
    }

    [Test]
    public void PercentCalculator_FourYears_FourPercent()
    {
        Assert.That(fdt.Discount(4), Is.EqualTo(0.04m));
    }

    [Test]
    public void PercentCalculator_FiveYears_FivePercent()
    {
        Assert.That(fdt.Discount(5), Is.EqualTo(0.05m));
    }

    [Test]
    public void PercentCalculator_MoreThanFiveYears_FivePercent()
    {
        Assert.That(fdt.Discount(6), Is.EqualTo(0.05m));
        Assert.That(fdt.Discount(100), Is.EqualTo(0.05m));
    }

    [Test]
    public void PercentCalculator_NegativeYear_ReturnZero()
    {
        Assert.That(fdt.Discount(-3), Is.EqualTo(0));
    }

    [Test]
    public void CommonCalculation_ZeroAmount_ReturnZero()
    {
        Assert.That(fdt.TierBasedDiscountCalculation(0, TierDiscountValue), Is.EqualTo(0));
    }

    [Test]
    public void CommonCalculation_PositiveAmount_ReturnPositive()
    {
        Assert.That(fdt.TierBasedDiscountCalculation(1, TierDiscountValue), Is.EqualTo(0.7m));
        Assert.That(fdt.TierBasedDiscountCalculation(10, TierDiscountValue), Is.EqualTo(7m));
    }
    
    [Test]
    public void CommonCalculation_NegativeAmount_ReturnNegative()
    {
        Assert.That(fdt.TierBasedDiscountCalculation(-1, TierDiscountValue), Is.EqualTo(-0.7m));
        Assert.That(fdt.TierBasedDiscountCalculation(-10, TierDiscountValue), Is.EqualTo(-7m));
    }

    [Test]
    public void MoreComplicatedCalculation_ZeroInput_ReturnZero()
    {
        Assert.That(fdt.TierBasedAmountCalculation(0, 0.5m), Is.EqualTo(0));
    }

    [Test]
    public void MoreComplicatedCalculation_PositiveInput_ReturnPositive()
    {
        Assert.That(fdt.TierBasedAmountCalculation(1, 0.5m), Is.EqualTo(0.5));
        Assert.That(fdt.TierBasedAmountCalculation(10, 0.5m), Is.EqualTo(5));
    }

    [Test]
    public void MoreComplicatedCalculation_NegativeInput_ReturnNegative()
    {
        Assert.That(fdt.TierBasedAmountCalculation(-1, 0.5m), Is.EqualTo(-0.5));
        Assert.That(fdt.TierBasedAmountCalculation(-10, 0.5m), Is.EqualTo(-5));
    }
}