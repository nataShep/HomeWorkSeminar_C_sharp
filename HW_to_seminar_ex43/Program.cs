// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 
void FindPointOfIntersection ()
 {
   Console.Write("Input k1 function1 = ");
   double k1F1 = Convert.ToDouble(Console.ReadLine());
   Console.Write("Input b1 function1 = ");
   double b1F1 = Convert.ToDouble(Console.ReadLine());

   Console.Write("Input k2 function2 = ");
   double k2F2 = Convert.ToDouble(Console.ReadLine());
   Console.Write("Input b2 function2 = ");
   double b2F2 = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine($"F1: y = {k1F1}x + {b1F1}");
   Console.WriteLine($"F2: y = {k2F2}x + {b2F2}");
   
   double x = (b2F2-b1F1)/(k1F1-k2F2);
   double y = (k1F1 * x) + b1F1;
   Console.WriteLine($"PointOfIntersection is ({x:f2}; {y:f2})");
 }   
    
FindPointOfIntersection();


