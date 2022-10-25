namespace IfTest;

public static class ExtensionHelper
{
    public static decimal NegativeToZero(this decimal value)
    {
        return (value < 0) ? 0 : value;
    }

    public static int NegativeToZero(this int value)
    {
        return (value < 0) ? 0 : value;
    }
}