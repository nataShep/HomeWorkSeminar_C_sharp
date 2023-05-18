// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. 14212 -> нет, 12821 -> да, 23432 -> да

void Palindrom(int num)
{
    int a = num/1000;
    int b = num % 100;
    int c = b%10 *10 + b/10;
    
    if (a == c)
    Console.WriteLine ("Your number is palindrom.");
    else
    Console.WriteLine ("Your number is't palindrom.");
}

Console.WriteLine("Input your number has 5 numeral= ");
 int number = Convert.ToInt32(Console.ReadLine());
     if (number < 10000 & number > 99999)
     Console.WriteLine("Your number hasn't 5 numeral");
     else Palindrom(number);