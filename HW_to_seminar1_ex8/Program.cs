// Задача 8: 
// Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
/*
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Алгоритм:
1. Запросить число
2. Проверить числа на чётность в интервале от 1 до заданного числа
4. Вывести все четные числа из интервала от 1 до заданного числа
*/

Console.Write("Input your number = ");
double number = Convert.ToInt32(Console.ReadLine());

int count = 1;

if (number > 0)
    while(count <= number)
    {
        if (count %2 == 0)
            Console.Write(count + " ");
            count++;
    }
if (number < 0)
    while(number <= count)
    {
        if (count %2 == 0)
            Console.Write(count + " ");
            count--;
    }
    