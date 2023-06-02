// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double [,] RandArr ()
{
    Console.Write("Input count of rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input count of columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input count of max = ");
    int max = Convert.ToInt32(Console.ReadLine());

    double [,] RandArray = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            RandArray[i,j] = Math.Round((new Random().Next(min, max) + new Random().NextDouble()),1);
        }
    }
    return RandArray;
} 

void Print2Array (double [,] array2d)
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

double [,] newArr = RandArr();
Print2Array (newArr);