namespace StrongRomanNumerals;

public class RomanNumerals
{
    public string Convert(int i) =>
        string.Join("", Enumerable.Range(0, i).Select(_ => "I"));
}
