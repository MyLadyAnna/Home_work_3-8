// Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] GetArray(int rows, int cols)
{
    int[,] array = new int[rows, rows];
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= rows * rows)      
    {
        // От array[0,0] -> до array[0,3] -> до array[3,3] -> до array[3,0] -> до array[1,0] -> до array[1,2]...

        array[i, j] = num;
        if (i <= j + 1 && i + j < rows - 1)         // заполнение строки слева направо
            ++j;
        else if (i < j && i + j >= rows - 1)        // сверху вниз
            ++i;
        else if (i >= j && i + j > rows - 1)        // справа налево
            --j;
        else
            --i;                                    // снизу в верх
        ++num;
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] massive = GetArray(4, 4);
PrintArray(massive);
