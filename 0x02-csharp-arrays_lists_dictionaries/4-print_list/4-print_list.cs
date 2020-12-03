using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List <int> l = new List<int> ();
        for (int i = 0; i < size; i++)
        {
            l.Add (i);
            if (i != 0)
                Console.Write(" ");
            Console.Write(i);
        }
        Console.WriteLine("");
        return l;
    }
}
