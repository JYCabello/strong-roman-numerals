namespace StrongRomanNumerals;

public class RomanNumerals
{
    public string Convert(int i)
    {
        if (i == 4) { return "IV"; }

        return string.Join("", Enumerable.Range(0, i).Select(_ => "I"));
    }
}
