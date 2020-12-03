using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> sList = new List<string>();
        foreach (string key in myDict.Keys)
            sList.Add(key);
        sList.Sort();
        foreach (string key in sList)
            Console.WriteLine("{0}: {1}", key, myDict[key]);
    }
}
