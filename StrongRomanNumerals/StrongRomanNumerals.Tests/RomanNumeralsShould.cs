using Xunit;

namespace StrongRomanNumerals.Tests;

public class RomanNumeralsShould
{
    [Fact(DisplayName = "convert 1 to I")]
    public void Test1()
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(1);
        Assert.Equal("I", result);
    }
}
