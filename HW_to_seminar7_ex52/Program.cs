// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] Array2d (int rows, int columns, int min, int max)
{
    int [,] Array2d = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array2d[i,j] = new Random().Next(min, max+1);
        }
    }
    return Array2d;
} 

void Print2Array (int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j=0; j< array2d.GetLength(1); j++)
        {
            Console.Write (array2d [i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageSummCol (int [,] arrayS)
{
    for (int j = 0; j < arrayS.GetLength(1); j++)
    {
       double sum = 0;
       int n = arrayS.GetLength(0);
       for (int i=0; i< n; i++)
        {
            sum += arrayS [i,j];       
        }  
    Console.Write($"{sum/n:f2}  ");    
    }   
}

Console.Write("Input count of rows = ");
int rows = Convert.ToInt32(Console.ReadLine());
 if (rows<0)
        Console.WriteLine ("The number of rows or columns must not be negative!");
else
{
Console.Write("Input count of columns = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of max = ");
int max = Convert.ToInt32(Console.ReadLine());
   
int [,] new2dArray = Array2d(rows, columns, min, max);
Print2Array (new2dArray);
AverageSummCol (new2dArray);
}
