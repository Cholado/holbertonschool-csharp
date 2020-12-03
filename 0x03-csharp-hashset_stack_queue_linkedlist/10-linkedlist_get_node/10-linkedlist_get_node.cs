using System;
using System.Collections.Generic;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;
        if (n >= myLList.Count)
            return (0);
        foreach (int num in myLList)
        {
            if (index == n)
                return (num);
            index++;
        }
        return (0);
    }
}
