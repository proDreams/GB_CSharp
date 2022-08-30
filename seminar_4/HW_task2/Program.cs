// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CountNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {
        int temp = number % 10;
        result += temp;
        number /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} - {CountNumbers(num)}");
