using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] grid = new int[5,5];
        grid [2,2] = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j != 0)
                    Console.Write(" ");
                Console.Write(grid[i,j]);
            }
            Console.WriteLine("");
        }
    }
}
