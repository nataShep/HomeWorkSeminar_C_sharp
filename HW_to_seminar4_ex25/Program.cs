// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵),
// 2, 4 -> 16

int Power ()
{
Console.Write("Input number1 = ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number2 = ");
int number2 = Convert.ToInt32(Console.ReadLine());

int P = 1;
for (int a = 1; a <= number2; a++)
{
    P = P * number1;
}
return P;
}

int res = Power ();
Console.WriteLine($"Result number1^number2 = {res}");