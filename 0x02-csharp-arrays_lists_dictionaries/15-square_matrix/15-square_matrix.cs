using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int mHeight = myMatrix.GetLength(0);
        int mWidth = myMatrix.GetLength(1);
        int temp = new int();
        int[,] newMatrix = new int[mHeight, mWidth];
        for (int i = 0; i < mHeight; i++)
        {
            for (int j = 0; j < mWidth; j++)
            {
                temp = myMatrix[i, j];
                newMatrix[i, j] = temp * temp;
            }
        }
        return (newMatrix);
    }
}
