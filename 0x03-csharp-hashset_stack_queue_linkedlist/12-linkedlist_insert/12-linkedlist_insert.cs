using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> strider = myLList.First;
        if (strider == null)
        {
            myLList.AddFirst(newNode);
            return (newNode);
        }
        if (strider.Value > n)
        {
            myLList.AddBefore(strider, newNode);
            return (newNode);
        }
        while (strider.Next != null)
        {
            if (strider.Next.Value >= n)
                break;
            strider = strider.Next;
        }
        myLList.AddAfter(strider, newNode);
        return (newNode);
    }
}
