// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum_digits_of_number (int n)
{
    int sum = n%10;
    int countD = 1;
    while (n > 9) 
    {
    n = n / 10;  
    sum = sum + n%10;   
    countD++;         
    }
    return sum;
}

Console.Write("Input your's number = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n/10 < 10)
{
    Console.WriteLine($"Summ all digits of your's number = {n/10+n%10}");
}
else
{
int res = Sum_digits_of_number (n);
Console.WriteLine($"Summ all digits of your's number = {res}");
}