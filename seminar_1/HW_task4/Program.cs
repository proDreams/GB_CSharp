// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int current = 2;
if (num > 1)
{
    while (current <= num)
    {
        Console.Write($"{current}");
        current += 2;
        if (current <= num) Console.Write(", ");
    }
}
else Console.WriteLine($"Нет последовательности для числа {num}");