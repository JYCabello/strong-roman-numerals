using Xunit;

namespace StrongRomanNumerals.Tests;

public class RomanNumeralsShould
{
    [Theory(DisplayName = "convert 1 to I")]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(6, "VI")]
    public void Convert(int i, string expectation)
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(i);
        Assert.Equal(expectation, result);
    }
}
