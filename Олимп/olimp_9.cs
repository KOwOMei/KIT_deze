using System;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        s = s.ToLower();
        bool IsPalindrome = true;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - i - 1])
            {
                IsPalindrome = false;
            }
        }
        Console.WriteLine(IsPalindrome);
        Console.ReadKey();
    }
}
