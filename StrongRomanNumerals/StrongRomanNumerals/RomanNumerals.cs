namespace StrongRomanNumerals;

public class RomanNumerals
{
    public static Dictionary<int, string> numeralMap =>
        new()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" }
        };

    public string Convert(int input)
    {
        return numeralMap[input];
    }
}
