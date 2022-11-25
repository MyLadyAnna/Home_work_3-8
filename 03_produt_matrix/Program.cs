// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

void FindProductOfmatrices(int[,] array1, int[,] array2, int[,] productionsArray)
{
    if (array1.GetLength(1) != array2.GetLength(0))         //если число столбцов первой матрицы совпадает с числом строк второй матрицы, то умножение можно выполнть.
   {
    Console.WriteLine("Произведение выполнить нельзя, так как число столбцов первой матрицы НЕсовпадает с числом строк второй матрицы");
   }
   else
    {
    //productionsArray[0,0] = array1[0,0]*array2[0,0] + array1[0,1]*array2[1,0]
    //productionsArray[0,1] = array1[0,0]*array2[0,1] + array1[0,1]*array2[1,1]
    //productionsArray[1,0] = array1[1,0]*array2[0,0] + array1[1,1]*array2[1,0]
    //productionsArray[1,1] = array1[1,0]*array2[0,1] + array1[1,1]*array2[1,1]
    for (int i = 0; i < productionsArray.GetLength(0); i++)
    {
       for (int j = 0; j < productionsArray.GetLength(1); j++)
       {
        int result = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
    {
        result += array1[i,k] * array2[k,j];
    }
        productionsArray[i, j] = result;
        Console.Write(productionsArray[i, j] + " ");
       } 
        Console.WriteLine();
    }
    }
    
}

Console.Clear();
Console.Write("Введите количество строк в 1 матрице: ");
int m1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов в 1 матрице: ");
int n1 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix1 = GetArrayRandom(m1, n1);
Console.Write("Введите количество строк во 2 матрице: ");
int m2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов во 2 матрице: ");
int n2 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix2 = GetArrayRandom(m2, n2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
int[,] resultMatrix = new int[m1,n2];            //// произведение матриц - новая матрица с кол-вом строк от 1 и столбцов от 2.
FindProductOfmatrices(matrix1, matrix2, resultMatrix);






