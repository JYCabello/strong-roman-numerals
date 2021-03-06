using Xunit;

namespace StrongRomanNumerals.Tests;

public class RomanNumeralsShould
{
    [Theory(DisplayName = "returns the expected output (duh)")]
    [InlineData("I", 1)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    public void Test1(string expected, int input)
    {
        var romanNumerals = new RomanNumerals();
        var result = romanNumerals.Convert(input);
        Assert.Equal(expected, result);
    }
}
