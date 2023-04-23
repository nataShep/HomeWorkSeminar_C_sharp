// Задача 6: 
// Напишите программу,
// которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
/*
4 -> да
-3 -> нет
7 -> нет
*/

/*
Алгоритм:
1. Запросить число
2. Спросить: "Четное или нечетное введенное число?"
3. Проверить на чётность
4. Вывести сообщение
*/

Console.Write("Input your number = ");
double number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Is your number EVEN or Odd?");

if (number %2 == 0) 
{
Console.WriteLine("Your number is EVEN!");
}
else
{
Console.WriteLine("Your number is Odd!");
}
