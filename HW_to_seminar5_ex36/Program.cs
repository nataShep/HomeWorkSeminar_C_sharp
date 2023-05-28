// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19, 
// [-4, -6, 89, 6] -> 0

int [] ArrayRandom (int size, int min, int max)
{
    int [] array36 = new int [size];
    for (int i = 0; i < size; i++)
        array36[i] = new Random().Next(min, max+1);
    return array36;
}

void ShowArray (int [] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
        Console.Write (arrayN[i] + ", ");
    Console.WriteLine("\b\b.");   
}

int SummOddElem (int [] SumElem)
{
    int sumN = 0;
    for (int i = 0; i < SumElem.Length; i++)
        if (i % 2 != 0)
        sumN += SumElem [i];
    return sumN;
}

Console.Write ("Input count of elements in array = ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input first number = ");
int minN = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second number = ");
int maxN = Convert.ToInt32(Console.ReadLine());
    if (minN < maxN)
    {
        int [] Array = ArrayRandom (sizeArray, minN, maxN);
        ShowArray (Array);
        int a = SummOddElem (Array); 
        Console.WriteLine($"Count of even numbers in array = {a}");
    }
    else
        Console.WriteLine("First number should be less then Second number!");