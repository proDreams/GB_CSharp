// Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");           // Вместо int использовал long для более больших чисел
long num = long.Parse(Console.ReadLine());  // Но всё равно упёрся в ограничение длины

if (num > 99)
{
    long third = num / 100 % 10;
    Console.WriteLine($"Третья цифра {third}");
}
else Console.WriteLine("Третьей цифры нет");