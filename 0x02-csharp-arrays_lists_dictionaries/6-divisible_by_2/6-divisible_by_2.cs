using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> yourList = new List<bool>();
        foreach (int num in myList)
        {
            if (num % 2 == 0)
                yourList.Add(true);
            else
                yourList.Add(false);
        }
        return (yourList);
    }
}
