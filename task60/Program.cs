int[,,] CreateMatrix(int rowCount, int columnCount, int widthCount, int min, int max)
{
    int[,,] array = new int[rowCount, columnCount, widthCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            for (int width = 0; width < array.GetLength(2); width++)
            {
                array[row, column, width] = new Random().Next(min, max + 1);
                Thread.Sleep(100);
            }

        }

    }
    return array;
}

//int ShaffeledArray(int digit)
//{

//int[] digitArray = new int[8];
//Random rand = new Random();
//for (int j = digitArray.Length; j >= 1; j--)
//{
//int k = rand.Next(j + 1);

//int tmp = digitArray[k];
//digitArray[k] = digitArray[j];
//digitArray[j] = tmp;
//}
//return digitArray[digit];
//}

void PrintMAtrix(int[,,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            for (int width = 0; width < array.GetLength(2); width++)
            {

                Console.Write($"{array[row, column, width]}({row},{column},{width}) ");

            }
        }
        Console.WriteLine();
    }
}


int[,,] array = CreateMatrix(2, 2, 2, 10, 99);
PrintMAtrix(array);
