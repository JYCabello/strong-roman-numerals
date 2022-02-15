using Xunit;

namespace StrongRomanNumerals.Tests;

public class RomanNumeralsShould
{
    [Theory(DisplayName = "convert 1 to I")]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    public void Convert(int i, string expectation)
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(i);
        Assert.Equal(expectation, result);
    }
}
