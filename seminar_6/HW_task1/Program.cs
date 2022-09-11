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

// int СountPositive(int first)
// {
//     int temp = first;
//     int count = 2;
//     int result = 0;
//     bool yesOrNo = true;
//     while (yesOrNo == true)
//     {
//         if (temp > 0) result++;
//         Console.Write("Продолжить? Да или Нет: ");
//         if (Console.ReadLine().ToLower() == "да")
//         {
//             Console.Write($"Введите {count}-е число: ");
//             temp = Convert.ToInt32(Console.ReadLine());
//             count++;
//         }
//         else break;


//     }
//     return result;
// }

// Console.Write("Введите 1-е число: ");
// int countNumbers = Convert.ToInt32(Console.ReadLine());
// int countPositive = СountPositive(countNumbers);
// Console.WriteLine($"Вы ввели {countPositive} чисел больше нуля.");