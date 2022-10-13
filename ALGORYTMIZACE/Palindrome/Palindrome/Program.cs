// See https://aka.ms/new-console-template for more information

Console.WriteLine(LongestPalindrome("galoabbaww", 0, 0));
Console.WriteLine(isPalindrome("abwqweba"));

string LongestPalindrome(string s, int x, int length)
{
    return null;
}

bool isPalindrome(string s)
{
    char[] charArray = s.ToCharArray();  
    Array.Reverse(charArray);
    return new string(charArray) == s;
}
