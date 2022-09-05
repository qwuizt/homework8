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

int[,] ChangePosition(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int minDigit = 0;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    minDigit = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = minDigit;
                }
            }
        }
        Console.WriteLine();
    }
    return array;
}

int[,] array = CreateMatrix(3, 4, 0, 9);
PrintMAtrix(array);
int[,] newArray = ChangePosition(array);
PrintMAtrix(newArray);