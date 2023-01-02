
using System.Net.Mail;

public delegate bool CheckStringValidity(string input);
class Program
{
    
    public static void Main(string[] args)
    {
        CheckStringValidity containsS = new CheckStringValidity(StringContainsLetterS);

        ObservableLimitedList limited = new ObservableLimitedList(containsS);

        string one = "Amit Kremer";
        string two = "Ron Bandel";
        string Three = "Roee Tals";
        string four = "Ziv Atad";
        string five = "LOLO";
        string Six = "Ron Menson";
        string Seven = "LOL";
        string Eight = "Meli Anderson";
        string Nine = "Poler Konsel";
        string Ten = "Lili Pelson";

        limited.TryAdd(one);
        limited.TryAdd(two);
        limited.TryAdd(Three);
        limited.TryAdd(four);
        limited.TryAdd(five);
        limited.TryAdd(Six);
        limited.TryAdd(Seven);
        limited.TryAdd(Eight);
        limited.TryAdd(Nine);
        limited.TryAdd(Ten);

        
        limited.PrintAll();

    }

    public static bool StringContainsLetterS(string input)
    {
        if (input.Contains("S") || input.Contains("s"))
        {
            return true;
        }
        return false;
    }

    
}
