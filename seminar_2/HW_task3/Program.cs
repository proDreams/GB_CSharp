// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine());

if (0 < day && day < 8)
{
    if (day == 6 || day == 7) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Ошибка, такого дня нет в неделе.");