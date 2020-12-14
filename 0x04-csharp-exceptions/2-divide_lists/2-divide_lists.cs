using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> newList = new List<int>();
        int nu = 0;
            for (int i = 0; i < listLength; i++)
            {
                nu = 0;
                try
                {
                    nu = list1[i] / list2[i];
                    newList.Add(nu);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    newList.Add(nu);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            }
        return (newList);
    }
}
