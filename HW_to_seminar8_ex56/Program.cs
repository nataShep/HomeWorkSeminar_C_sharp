// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] QuadroArray (int r, int c, int min, int max)
{
    int [,] arrQ = new int [r,c];
    for (int i=0; i<r; i++)
        for (int j=0; j<c; j++)
            arrQ[i,j] = new Random().Next(min, max+1);
    return arrQ;
}
            
void ShowArr (int [,] arrQ)
{
    for (int i=0; i<arrQ.GetLength(0); i++)
    {
        for (int j=0; j<arrQ.GetLength(1); j++)
        {
            Console.Write (arrQ[i,j] + " "); 
        }
    Console.WriteLine();         
    }  
}

int SumR (int [,] arrQ, int i)
{
    int sumR = 0; 
    for (int j=0; j<arrQ.GetLength(1); j++)
        {
            sumR += arrQ[i,j]; 
        }
    return sumR;
}
                
Console.Write("Input count rows & columns = ");
int r = Convert.ToInt32(Console.ReadLine());
int c = r;
Console.Write("Input min number = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number = ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] Array = QuadroArray (r, c, min, max);
ShowArr (Array);

int minSumRow = 0;
int sumR = SumR (Array,0);
    for (int i=0; i<Array.GetLength(0); i++)
    {
        int temp = SumR (Array,i);
        if (sumR > temp)
        {
            sumR = temp;
            minSumRow = i;
        }  
    }   
Console.WriteLine($"Number of row has min summ of elements: {minSumRow+1}, Summ = {sumR}.");

