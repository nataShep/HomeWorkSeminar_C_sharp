// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] ArrayRandom (int size, int min, int max)
{
    double [] array38 = new double [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array38[i] = rand.Next(min, max+1) + rand.NextDouble();
    }    
    return array38;
}

void ShowArray (double [] arrayN)
{
    for (int i = 0; i < arrayN.Length; i++)
       Console.WriteLine (arrayN[i] + " ");  
}

double FindMinNum (double [] minNum)
{
    double minVal = minNum [0];
    for (int i = 0; i < minNum.Length; i++)
        if (minNum[i] < minVal)
        minVal = minNum[i];
    return minVal;
}

double FindMaxNum (double [] maxNum)
{
    double maxVal = maxNum [0];
    for (int i = 0; i < maxNum.Length; i++)
        if (maxNum[i] > maxVal)
        maxVal = maxNum[i];
    return maxVal;
}

Console.Write ("Input count of elements in array = ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input first number = ");
int minN = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second number = ");
int maxN = Convert.ToInt32(Console.ReadLine());
    if (minN < maxN)
    {
        double [] Array = ArrayRandom (sizeArray, minN, maxN);
        ShowArray (Array);
        double a = FindMinNum (Array); 
        double c = FindMaxNum (Array);
        Console.WriteLine($"The difference between the maximum and minimum number of an array = {c - a}");
    }
    else
        Console.WriteLine("First number should be less then Second number!");
