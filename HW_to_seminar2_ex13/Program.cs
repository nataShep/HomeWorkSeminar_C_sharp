// Задача 13: 
// Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6


void View3num(int num)
{
    int a = num / 10;
        while (a>1000 || a<-1000) a=a/10;
            if (a > 99 || a < -99) 
        {
          a=a%10;
          if (a > 0)
            {
            int num3 = a;
            Console.WriteLine("3rd numeral of your number: " + num3);
            }
            else
            {
               int num3 = - a;
               Console.WriteLine("3rd numeral of your number: " + num3); 
            }
        }

        else
        {
            if (a > 0)
            {
            int num3 = num - (a*10);
            Console.WriteLine("3rd numeral of your number: " + num3);
            }
            else
            {
               int num3 = - (num - (a*10));
               Console.WriteLine("3rd numeral of your number: " + num3); 
            }
        }
}

Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100 && number > -100)
        Console.WriteLine("Your number hasn't 3rd numeral");
    else View3num(number);
