//Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да, 7 -> да, 1 -> нет

void DayOfWeek (int a)
{ 
if (a < 6)
    Console.WriteLine($"It number's day = {a} isn't weekend");
else
    Console.WriteLine($"It number's day = {a} is weekend");
}

Console.WriteLine("Input number's day of the week: ");
int numDay = Convert.ToInt32(Console.ReadLine());
    if (numDay > 7 || numDay < 1)
    Console.WriteLine("Your number doesn't number's day of the week.");
    else DayOfWeek(numDay);