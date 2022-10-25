using IfTest;

namespace IfTestTests;

public class HelperTests
{
    [Test]
    public void NegativeToZero_ZeroInput_ZeroOutput()
    {
        var decimalValue = 0m;
        Assert.That(decimalValue.NegativeToZero(), Is.EqualTo(0));

        var intValue = 0;
        Assert.That(intValue.NegativeToZero(), Is.EqualTo(0));
    }

    [Test]
    public void NegativeToZero_NegativeInput_ZeroOutput()
    {
        var decimalValue = -3m;
        Assert.That(decimalValue.NegativeToZero(), Is.EqualTo(0));

        decimalValue = -10m;
        Assert.That(decimalValue.NegativeToZero(), Is.EqualTo(0));

        decimalValue = -30m;
        Assert.That(decimalValue.NegativeToZero(), Is.EqualTo(0));


        var intValue = -3;
        Assert.That(intValue.NegativeToZero(), Is.EqualTo(0));

        intValue = -10;
        Assert.That(intValue.NegativeToZero(), Is.EqualTo(0));

        intValue = -30;
        Assert.That(intValue.NegativeToZero(), Is.EqualTo(0));
    }

    [Test]
    public void NegativeToZero_PositiveInput_PositiveOutput()
    {
        var decimalValue = 5m;
        Assert.That(decimalValue.NegativeToZero(), Is.EqualTo(5));
        
        decimalValue = 10m;
        Assert.That(decimalValue.NegativeToZero(), Is.EqualTo(10));


        var intValue = 5;
        Assert.That(intValue.NegativeToZero(), Is.EqualTo(5));

        intValue = 10;
        Assert.That(intValue.NegativeToZero(), Is.EqualTo(10));
    }
}