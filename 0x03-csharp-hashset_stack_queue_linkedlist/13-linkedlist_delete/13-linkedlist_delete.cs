using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedListNode<int> strider = myLList.First;
        for (; i < index && strider.Next != null; i++)
            strider = strider.Next;
        if (i == index)
            myLList.Remove(strider);
    }
}
