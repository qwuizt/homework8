int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] array = new int[rowCount, columnCount];
    int digit = 1;
    for (int x = 0; x < array.GetLength(1); x++)
    {
        array[0, x] = digit;
        digit++;
    }
    for (int y = 1; y < array.GetLength(0); y++)
    {
        array[y, array.GetLength(1) - 1] = digit;
        digit++;
    }
    for (int x = array.GetLength(1) - 2; x > 0; x--)
    {
        array[array.GetLength(0) - 1, x] = digit;
        digit++;
    }
    for (int y = array.GetLength(0) - 1; y >= 1; y--)
    {
        array[y, 0] = digit;
        digit++;
    }
    for (int x = 1; x < array.GetLength(1) - 1; x++)
    {
        array[1, x] = digit;
        digit++;
    }
    for (int x = array.GetLength(1) - 2; x >= 1; x--)
    {
        array[2, x] = digit;
        digit++;
    }

    return array;
}
void PrintMAtrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateMatrix(4, 4);
PrintMAtrix(array);
