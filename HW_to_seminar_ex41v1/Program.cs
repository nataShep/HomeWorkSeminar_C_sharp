// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write ("Enter the number of numbers you want = ");
int m = Convert.ToInt32(Console.ReadLine());
    if (m>0)
    {
        int [] array = WishArray (m);
        int count = CountPositiveN (array);
        Console.WriteLine($"Count of positive numbers = {count}"); 
    } 
    else
    Console.WriteLine("Count of number should be > 0!");

int [] WishArray (int size)
{
    int [] ArrayN = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write ($"Input your {i+1} number = ");
        int num = Convert.ToInt32(Console.ReadLine());
        ArrayN [i] = num;         
    }
    return ArrayN;
}

int CountPositiveN (int [] wishArray)
{
    int positiveNum = 0;
    for (int i = 0; i < wishArray.Length; i++)
    if (wishArray [i] > 0)
        positiveNum ++;
    return positiveNum;
}