using IfTest;

namespace IfTestTests;

public class DiscountsTests
{
    private FakeDiscountTire fdt = new FakeDiscountTire();
    private const decimal TierDiscountValue = 0.7m;

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

    [Test]
    public void LoyaltyCalculation_ZeroInputPositiveAmount_ReturnZero()
    {
        Assert.That(fdt.LoyaltyCalculation(0, 1.0m, 0.5m), Is.EqualTo(0));
        Assert.That(fdt.LoyaltyCalculation(0, 10m, 0.5m), Is.EqualTo(0));
    }

    [Test]
    public void LoyaltyCalculation_LessThan5YearsPositiveAmount_ReturnPositive()
    {
        Assert.That(fdt.LoyaltyCalculation(1, 10m, 0.5m), Is.EqualTo(0.05));
        Assert.That(fdt.LoyaltyCalculation(2, 10m, 0.5m), Is.EqualTo(0.1));
        Assert.That(fdt.LoyaltyCalculation(3, 10m, 0.5m), Is.EqualTo(0.15));
        Assert.That(fdt.LoyaltyCalculation(4, 10m, 0.5m), Is.EqualTo(0.2));
    }

    [Test]
    public void LoyaltyCalculation_MoreThan5YearsPositiveAmount_ReturnPositiveAllEqual()
    {
        Assert.That(fdt.LoyaltyCalculation(5, 10m, 0.5m), Is.EqualTo(0.25));
        Assert.That(fdt.LoyaltyCalculation(6, 10m, 0.5m), Is.EqualTo(0.25));
        Assert.That(fdt.LoyaltyCalculation(10, 10m, 0.5m), Is.EqualTo(0.25));
        Assert.That(fdt.LoyaltyCalculation(20, 10m, 0.5m), Is.EqualTo(0.25));
    }

    [Test]
    public void LoyaltyCalculation_NegativeYearsPositiveAmount_ReturnZero()
    {
        Assert.That(fdt.LoyaltyCalculation(-5, 10m, 0.5m), Is.EqualTo(0));
        Assert.That(fdt.LoyaltyCalculation(-6, 10m, 0.5m), Is.EqualTo(0));
        Assert.That(fdt.LoyaltyCalculation(-10, 10m, 0.5m), Is.EqualTo(0));
        Assert.That(fdt.LoyaltyCalculation(-20, 10m, 0.5m), Is.EqualTo(0));
    }
}