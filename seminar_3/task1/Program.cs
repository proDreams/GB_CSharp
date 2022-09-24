// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0)
{
    if (y > 0) Console.WriteLine("I четверть");
    else Console.WriteLine("IV четверть");
}
else if (x < 0)
{
    if (y < 0) Console.WriteLine("III четверть");
    else Console.WriteLine("II четверть");
}

for