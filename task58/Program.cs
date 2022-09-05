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

int[,] MultiplicationMatrixs(int[,] arra1, int[,] arra2)
{
    int[,] newArray = new int[arra1.GetLength(0), arra2.GetLength(1)];
    if (arra1.GetLength(1) == arra2.GetLength(0))
    {
        for (int i = 0; i < arra1.GetLength(0); i++)
        {
            for (int j = 0; j < arra2.GetLength(1); j++)
            {
                for (int k = 0; k < arra2.GetLength(0); k++)
                {
                    newArray[i, j] += arra1[i, k] * arra2[k, j];
                }
            }
        }
    }
    else Console.WriteLine("Матрицы невозможно умножить");
    return newArray;
}

int[,] array1 = CreateMatrix(2, 3, 0, 9);
int[,] array2 = CreateMatrix(3, 2, 0, 9);
PrintMAtrix(array1);
Console.WriteLine();
PrintMAtrix(array2);
Console.WriteLine("-------------");
int[,] myArray = MultiplicationMatrixs(array1, array2);
PrintMAtrix(myArray);
