namespace StrongRomanNumerals;

public class RomanNumerals
{
    private static readonly Dictionary<int, string> Lookup = new()
    {
        { 1, "I" },
        { 4, "IV" },
        { 5, "V" }
    };

    public string Convert(int i)
    {
        return Go(i, "");
        
        string Go(int index, string value)
        {
            if (index == 0) {  return value; }

            var highestMatch = Lookup
                .Keys
                .OrderByDescending(k => k)
                .First(k => k <= index);
            var symbol = Lookup[highestMatch];

            return Go(index - highestMatch, value + symbol);
        }
    }
}
