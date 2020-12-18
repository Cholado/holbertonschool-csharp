using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Performs operations on text string inputs.</summary>
    public class Str
    {
        ///<summary>Determines index of first non-repeating character.</summary>
        public static int UniqueChar(string s)
        {
            List<char> reject = new List<char>();
            Dictionary<char, int> hold = new Dictionary<char, int>();
            int idx = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (reject.Contains(s[i]))
                    continue;
                if (hold.ContainsKey(s[i]))
                {
                    reject.Add(s[i]);
                    hold.Remove(s[i]);
                    continue;
                }
                hold.Add(s[i], i);
            }
            foreach (KeyValuePair<char, int> uniq in hold)
            {
                if (uniq.Value < idx || idx == -1)
                    idx = uniq.Value;
            }
            return (idx);
        }
    }
}
