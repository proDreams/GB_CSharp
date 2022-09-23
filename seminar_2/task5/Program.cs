// 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int sqr1 = num1 * num1;
int sqr2 = num2 * num2;

// if (sqr1 != num2 && sqr2 != num1) Console.WriteLine("Нет");
// else Console.WriteLine("Да");

// if (sqr1 == num2 || sqr2 == num1) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

if (sqr1 == num2) Console.WriteLine("Да");
else if (sqr2 == num1) Console.WriteLine("Да");
else Console.WriteLine("Нет");
