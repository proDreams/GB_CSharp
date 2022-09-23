// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = num % 10;
Console.WriteLine(result);