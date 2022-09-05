int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max + 1);

        }

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

void CompareSumStringMatrix(int[,] array)
{
    int minString = 0;
    int sum = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += array[i, j];
                minSum += array[i, j];
            }
            else sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minString = i;
        }
        sum = 0;
    }

    Console.WriteLine($"минимальная сумма в {minString} строке");
}
int[,] array = CreateMatrix(4, 3, 0, 9);
PrintMAtrix(array);
CompareSumStringMatrix(array);
