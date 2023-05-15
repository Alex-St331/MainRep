using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsPalindrome("Able was I, ere I saw Elba"));
    }

    static bool IsPalindrome(string s)
    {
        string cleaned = Regex.Replace(s, "[^A-Za-z0-9]", "").ToLower();
        char[] charArray = cleaned.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        return cleaned == reversed;
    }
}
