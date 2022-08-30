// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += 1;
        number /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {num} - {CountNumbers(num)} цифр(ы).");
