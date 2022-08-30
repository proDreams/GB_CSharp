// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        result += i;
    }
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {num} = {SumNumbers(num)}");
