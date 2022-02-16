namespace StrongRomanNumerals;

public class RomanNumerals
{
    public string Convert(int input)
    {
        switch (input) {
            case 1:
                return "I";
            case 4:
                return "IV";
            case 5:
                return "V";
            default:
                return "";
        }
    }
}
