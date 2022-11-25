// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] GetArrayRandom(int rows, int cols, int height, int minValue = 10, int maxValue = 100)
{
    int[,,] array = new int[rows, cols, height];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number = rnd.Next(minValue, maxValue);
                if (RepeatingAnElement(array, number))              // пока в массиве есть число равное number, программа будет присваивать рандомные числа number. Как только из функции вернётся false, программа присвоет элем-ту массива число number 
                    continue;
                array[i, j, k] = number;
            }
        }
    }
    return array;
}

bool RepeatingAnElement(int[,,] array, int foundNum)            // сверяем элементы массива с рандомным числом, которое предлагает программа
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == foundNum)
                {
                    return true;
                }
            }
        }
    }
    return false;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Console.Write($"({i}, {j}, ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 3 размер массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,,] massive = GetArrayRandom(m, n, k);
PrintArray(massive);