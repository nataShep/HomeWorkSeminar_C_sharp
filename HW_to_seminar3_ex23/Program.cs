// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cube()
{
    Console.Write("Input number = ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num>0)
    {
        int currentN = 1;
        while (currentN <= num)
        {
            int res = currentN*currentN*currentN;
            Console.Write($"{res}, ");
            currentN++;
        }
        Console.WriteLine("\b\b.");
    }
    //else Console.WriteLine("Impossible value!");
    else
    {
        int currentN = 1;
        while (currentN >= num)
        {
            int res = currentN*currentN*currentN;
            Console.Write($"{res}, ");
            currentN--;
        }
        Console.WriteLine("\b\b.");
    }
}
Cube();