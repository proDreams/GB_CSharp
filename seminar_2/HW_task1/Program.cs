// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

if (99 < num && num < 1000)
{
    int second = num / 10 % 10;
    Console.WriteLine($"Вторая цифра {second}");
}
else Console.WriteLine("Введено не трёхзначное число.");