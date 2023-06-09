// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ShowSumNumbers (int M, int N)
{
    if (M==N) return N;                        
    else return M + ShowSumNumbers(M+1,N);
}

int res = ShowSumNumbers (4,8);
Console.Write (res);