// Задача 29: Напишите программу, которая задаёт массив из произвольного количества элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] RandomArray (int size, int min, int max)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
      array [i] = new Random().Next(min, max+1);
    return array;
}

void ShowArray (int [] array)
{
 for (int i = 0; i < array.Length; i++)
   Console.Write(array [i] + ", ");
   Console.WriteLine("\b\b.");
}

Console.Write("Enter count of elements in array = ");
int countOfElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min number in array = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max number in array = ");
int max = Convert.ToInt32(Console.ReadLine());
if (min > max)
{
    Console.Write("It number is imposible! Enter min number < max number!");
}
else
{
int [] array1 = RandomArray (countOfElements, min, max);
ShowArray (array1);
}