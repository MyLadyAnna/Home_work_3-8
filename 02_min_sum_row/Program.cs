// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
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

void FindRowWithMinSum(int[,] array)
{
    int lineNumb = 0;
    //int sum = 0;
    int min = 0;
    for (int i = 0; i < array.GetLength(1); i++)        // за мин сумму принимаем 1 строку
    {
        min += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            lineNumb = i;
        }
        //sum = 0;

    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {lineNumb+1}");       // индекс - lineNumb, а в задании нужна найти номер стороки
}

Console.Clear();
Console.Write("Введите количество строк в прямоугольном массиве: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов в прямоугольном массиве: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] massive = GetArrayRandom(m, n);
PrintArray(massive);
Console.WriteLine();
FindRowWithMinSum(massive);

