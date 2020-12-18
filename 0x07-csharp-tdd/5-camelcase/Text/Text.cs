using System;

namespace Text
{
    ///<summary>Performs operations on text string inputs.</summary>
    public class Str
    {
        ///<summary>Counts words in a camelCase string.</summary>
        public static int CamelCase(string s)
        {
            int count = 1;
            if (s == null || s.Length == 0)
                return (0);
            foreach (char daffy in s)
            {
                if (Char.IsUpper(daffy))
                    count++;
            }
            return (count);
        }
    }
}
