// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ArrayRandom(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max+1);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input count of rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max = ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[rows, columns];
int[,] array2 = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

ArrayRandom(array1, min, max);
PrintArray(array1);

Console.WriteLine();

ArrayRandom(array2, min, max);
PrintArray(array2);

Console.WriteLine();

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int a = 0; a < array1.GetLength(1); a++)
        {
            resultArray[i, j] += array1[i, a] * array2[a, j];
        }
    }
}

PrintArray(resultArray);