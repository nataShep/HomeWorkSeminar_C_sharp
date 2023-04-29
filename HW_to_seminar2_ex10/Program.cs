// Задача 10:
//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

void Vew2digit(int number)
{
int a = number % 100;
int a2 = a / 10;
Console.WriteLine(a2);
}

Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
Vew2digit(number);
else Console.WriteLine("Your number must be three digits!");