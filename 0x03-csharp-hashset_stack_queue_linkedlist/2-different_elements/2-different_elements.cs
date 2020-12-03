using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        foreach (int num in list1)
        {
            if (list2.Contains(num))
                continue;
            else
                newList.Add(num);
        }
        foreach (int num in list2)
        {
            if (list1.Contains(num))
                continue;
            else
                newList.Add(num);
        }
        newList.Sort();
        return (newList);
    }
}
