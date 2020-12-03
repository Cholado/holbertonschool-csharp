using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        List<int> sList = new List<int>();
        Dictionary<int, string> iDict = new Dictionary<int, string>();
        foreach (KeyValuePair<string, int> kvp in myList)
        {
            iDict[kvp.Value] = kvp.Key;
            sList.Add(kvp.Value);
        }
        if (sList.Count == 0)
            return ("None");
        sList.Sort();
        return (iDict[sList[sList.Count - 1]]);

    }
}
