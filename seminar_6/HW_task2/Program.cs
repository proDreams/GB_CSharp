// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] CrossPoint(double[,] array)
{
    double[] points = new double[2];
    points[0] = (array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0]);
    points[1] = array[0, 0] * points[0] + array[0, 1];
    return points;
}


double[,] straight = new double[2, 2];
Console.Write("Введите координату k1: ");
straight[0, 0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату b1: ");
straight[0, 1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату k2: ");
straight[1, 0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату b2: ");
straight[1, 1] = Convert.ToInt32(Console.ReadLine());
double[] crossPoints = new double[2];

if (straight[0, 0] == straight[1, 0] & straight[0, 1] != straight[1, 1]) Console.WriteLine("Прямые паралельны");
else if (straight[0, 0] == straight[1, 0] & straight[0, 1] == straight[1, 1]) Console.WriteLine("Прямые совпадают");
else
{
    crossPoints = CrossPoint(straight);
    Console.WriteLine($"Точки пересечения: ({String.Join("; ", crossPoints)})");
}