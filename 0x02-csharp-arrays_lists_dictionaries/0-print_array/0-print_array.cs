using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] array1 = new int[size];
        for (int i = 0; i < size; i++)
        {
            array1[i] = i;
            if (i != 0)
                Console.Write(" ");
            Console.Write(i);
        }
        Console.WriteLine("");
        return array1;
    }
}
