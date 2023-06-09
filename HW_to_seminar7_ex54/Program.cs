// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] newArray (int row, int column, int min, int max)
{
    int [,] ArrayNew = new int [row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j< column; j++)
        {
            ArrayNew [i,j] = new Random().Next(min, max+1);
        }
    return ArrayNew;
}

void PrintArrayNew (int [,] ArrayNew)
{
    for (int i = 0; i < ArrayNew.GetLength(0); i++)
    {
        for (int j = 0; j< ArrayNew.GetLength(1); j++)
        {
            Console.Write (ArrayNew [i,j] + " ");
        }
    Console.WriteLine();
    }  
Console.WriteLine();    
}

void changeMaxToMin (int [,] ArrayNew)
{ 
    for (int i = 0; i < ArrayNew.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayNew.GetLength(1); j++)
        {
            for (int a = 0; a < ArrayNew.GetLength(1)-1; a++)
            {
                if (ArrayNew [i,a] < ArrayNew[i,a+1])
                    {
                       int temp = ArrayNew [i,a+1];
                       ArrayNew [i,a+1] = ArrayNew[i,a];
                       ArrayNew[i,a] = temp;
                    }
            }
        }    
    }
}

Console.Write("Input count rows = ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count columns = ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number = ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] Array = newArray (r, c, min, max);
PrintArrayNew (Array);
changeMaxToMin(Array);
Console.WriteLine();
PrintArrayNew (Array);
