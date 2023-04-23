// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Алгоритм:
1. Запросить 2 числа
2. Сравнить их
3. Вывести максимальное и минимальное
*/

Console.Write("Input your 1st number: a = ");
double number1 = Convert.ToInt32(Console.ReadLine ());

Console.Write("Input your 2st number: b = ");
double number2 = Convert.ToInt32(Console.ReadLine ());

if (number1 > number2)
{
    Console.WriteLine("max = числу a = " + number1);
    Console.WriteLine("min = числу b = " + number2);
}
else
{
Console.WriteLine("max = числу b = " + number2);
Console.WriteLine("min = числу a = " + number1);
}