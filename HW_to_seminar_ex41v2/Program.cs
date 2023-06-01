// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write ("Enter the number of numbers you want = ");
int m = Convert.ToInt32(Console.ReadLine());
        if (m>0) 
    {
        Console.Write ("Input min number = ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write ("Input max number = ");
        int num2 = Convert.ToInt32(Console.ReadLine());
         if (num1 < num2)
            {
                int [] array = WishArray (m, num1, num2);
                ShowWishArray (array);
                int count = CountPositiveN (array);
                Console.WriteLine($"Count of positive numbers = {count}");
            }
            else
               Console.WriteLine("Min number should be < Max number!"); 
    }
    else
    Console.WriteLine("Count of number should be > 0!");

int [] WishArray (int size, int min, int max)
{
    int [] ArrayN = new int [size];
    for (int i = 0; i < size; i++)
        ArrayN [i] = new Random().Next(min, max + 1);
    return ArrayN;
}

void ShowWishArray (int [] wishArray)
{
    for (int i = 0; i < wishArray.Length; i++) 
    Console.Write(wishArray [i] + ", ");
    Console.WriteLine();    
}

int CountPositiveN (int [] wishArray)
{
    int positiveNum = 0;
    for (int i = 0; i < wishArray.Length; i++)
    if (wishArray [i] > 0)
        positiveNum ++;
    return positiveNum;
}
