namespace StrongRomanNumerals;

public class RomanNumerals
{
    public static readonly Dictionary<int, string> numeralMap =
        new()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" }
        };

    public string Convert(int input)
    {
        var (number, symbol) =
            numeralMap
                .OrderByDescending(kv => kv.Key)
                .First(kv => input >= kv.Key);

        if (input - number >= number)
            return symbol + Convert(input - number);

        return numeralMap[input];
    }
}
