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
