namespace StrongRomanNumerals;

public class RomanNumerals
{
    public static readonly IOrderedEnumerable<KeyValuePair<int, string>> numeralMap =
        new Dictionary<int,string>()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 10, "X" }
        }.OrderByDescending(kv => kv.Key);

    public string Convert(int input)
    {
        var (number, symbol) =
            numeralMap
                .First(kv => input >= kv.Key);

        if (input - number >= number)
            return symbol + Convert(input - number);

        return numeralMap.Single(kv => kv.Key == input).Value;    
    }
}
