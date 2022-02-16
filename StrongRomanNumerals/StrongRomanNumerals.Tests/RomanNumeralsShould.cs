using Xunit;

namespace StrongRomanNumerals.Tests;

public class RomanNumeralsShould
{
    [Theory(DisplayName = "returns the expected output (duh)")]
    [InlineData("I", 1)]
    [InlineData("V", 5)]
    public void Test1(string expected, int input)
    {
        var romanNumerals = new RomanNumerals();
        string result = romanNumerals.Convert(input);
        Assert.Equal(expected, result);
    }
}
