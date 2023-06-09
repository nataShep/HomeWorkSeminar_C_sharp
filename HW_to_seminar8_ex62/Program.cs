// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void ArraySpiral(int[,] array, int size)
{
    int n = 1;
    int i = 0;
    int j = 0;

    while (n <= size * size)
    {
        array [i, j] = n;
            if (i <= j + 1 && i + j < size - 1)
                j++;
            else 
                if (i < j && i + j >= size - 1)
                    i++;
                else 
                    if (i >= j && i + j > size - 1)
                        j--;
                    else
                        i--;
        n++;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input the size of array = ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] arrQ = new int[size, size];

ArraySpiral(arrQ, size);
PrintArray(arrQ);