// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату x точки A: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int y2 = int.Parse(Console.ReadLine());

int x = (x2 - x1) * (x2 - x1);
int y = (y2 - y1) * (y2 - y1);
double sum = x + y;
double d = Math.Sqrt(sum);

Console.WriteLine($"{d:f2}");