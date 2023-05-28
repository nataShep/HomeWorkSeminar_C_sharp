// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] ArrayRandom (int size, int min, int max)
{
    int [] array3digits = new int [size];
    for (int i = 0; i < size; i++)
        array3digits[i] = new Random().Next(min, max+1);
    return array3digits;
}

void ShowArray (int [] array3)
{
    for (int i = 0; i < array3.Length; i++)
        Console.Write (array3[i] + ", ");
    Console.WriteLine("\b\b.");   
}

int CountEvenNum (int [] countEven)
{
    int n = 0;
    for (int i = 0; i < countEven.Length; i++)
        if (countEven[i] % 2 == 0)
        n++;
    return n;
}

Console.Write ("Input count of elements in array = ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input first 3 digits positive number = ");
int minN = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second 3 digits positive number = ");
int maxN = Convert.ToInt32(Console.ReadLine());
if (minN<100 || minN>1000 || minN<0 || maxN<0 || maxN<100 || maxN>1000)
   Console.WriteLine("Input 3 digits positive number!");
else
{
    if (minN < maxN)
    {
        int [] Array = ArrayRandom (sizeArray, minN, maxN);
        ShowArray (Array);
        int a = CountEvenNum (Array); 
        Console.WriteLine($"Count of even numbers in array = {a}");
    }
    else
        Console.WriteLine("First number should be less then Second number!");
}
