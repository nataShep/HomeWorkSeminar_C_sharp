// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthDist = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return lengthDist;
}
Console.Write("Input X coordinate of A = ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of A = ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinate of A = ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input X coordinate of B = ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate of B = ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z coordinate of B = ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double Way = Distance (xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);

Console.WriteLine($"Distance AB is {Way:f2}");
