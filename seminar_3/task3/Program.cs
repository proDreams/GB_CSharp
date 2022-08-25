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