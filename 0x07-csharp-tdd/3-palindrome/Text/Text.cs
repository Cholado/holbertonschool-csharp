using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Performs operations on text string inputs.</summary>
    public class Str
    {
        ///<summary>Determines if text is a palindrome.</summary>
        public static bool IsPalindrome(string s)
        {
            List<char> strip = new List<char>();
            foreach (char red in s)
            {
                if (!Char.IsPunctuation(red) && !Char.IsWhiteSpace(red))
                {
                    strip.Add(Char.ToLower(red));
                }
            }
            if (strip.Count == 0)
                return (true);
            List<char> rev = new List<char>(strip);
            rev.Reverse();
            return (strip.SequenceEqual(rev));
        }
    }
}
