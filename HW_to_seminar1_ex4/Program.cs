// Задача 4: 
// Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Алгоритм:
1. Запросить 3 числа
2. Сравнить их по-очереди
3. Вывести максимальное из них
*/

Console.Write("Input 1st numbers = ");
double num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 2nd numbers = ");
double num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input 3rd numbers = ");
double num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
Console.WriteLine("max = 1st number = " + num1);
}

if (num2 > num1 && num2 > num3)
{
Console.WriteLine("max = 2nd number = " + num2);
}

if (num3 > num2 && num3 > num1)
{
Console.WriteLine("max = 3rd number = " + num3);
}