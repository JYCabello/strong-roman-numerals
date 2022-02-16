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
        var kv =
            numeralMap
                .OrderByDescending(kv => kv.Key)
                .First(kv => input >= kv.Key);
        var symbol = kv.Value;

        if (input - kv.Key >= kv.Key)
            return symbol + Convert(input - kv.Key);

        return numeralMap[input];
    }
}
