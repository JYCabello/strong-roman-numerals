namespace StrongRomanNumerals;

public class RomanNumerals
{
    private static readonly Dictionary<int, string> Lookup = new()
    {
        { 1, "I" },
        { 2, "II" },
        { 3, "III" },
        { 4, "IV" },
        { 5, "V" }
    };

    public string Convert(int i)
    {
        var highestMatch = Lookup
            .Keys
            .OrderByDescending(k => k)
            .First(k => k == i);
        return Lookup[highestMatch];
    }
}
