Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int sqr_b = Convert.ToInt32(Math.Pow(b, 2));
if (a == sqr_b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}