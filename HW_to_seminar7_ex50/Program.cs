// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write ("Enter count of rows in array = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter count of columns in array = ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter a minimal number in array = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter a maxsimal number in array = ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write ("To find the value of the array element:");
Console.Write ("Enter the position number of the array row = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter the position number of the array column = ");
int b = Convert.ToInt32(Console.ReadLine());
    if (a<=row && b<=cols && a>0 && b>0)
    {
       int [,] arr = Array (row, cols, min, max);
       ShowArr (arr);
       ShowElem (arr);
    }
    else
    Console.WriteLine ("The input array element does not exist!");

int [,] Array (int r, int c, int min, int max)
{
    int [,] createArr = new int [r,c];
        for (int i=0; i<r; i++)
        {
            for (int j=0; j<c; j++)
            {
                createArr [i,j] = new Random().Next(min, max+1);
            }
        }
    return createArr; 
}

void ShowArr (int [,] Array)
{
    for (int i=0; i<Array.GetLength(0); i++)
    {
        for (int j=0; j<Array.GetLength(1); j++)
        {
            Console.Write (Array [i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowElem (int [,] Array)
{
    int A = a-1;
    int B = b-1;
    for (int i=0; i<Array.GetLength(0); i++)
    {
        for (int j=0; j<Array.GetLength(1); j++)
        {
            if (i==A && j==B)
            {
                Array [i,j] = Array [A,B];
                Console.Write ($"The value of the element of the array to be found = {Array [i,j]}");
            } 
        }
        
    }
}