// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int СountPositive(int count)
{
    int result = 0;
    for (int i = 1; i <= count; i++)
    {
        Console.Write($"Введите {i} число: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) result++;
    }
    return result;
}

Console.Write("Введите количество чисел: ");
int countNumbers = Convert.ToInt32(Console.ReadLine());
int countPositive = СountPositive(countNumbers);
Console.WriteLine($"Вы ввели {countPositive} числа больше нуля.");