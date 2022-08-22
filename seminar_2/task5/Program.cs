Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int sqr1 = num1 * num1;
int sqr2 = num2 * num2;

if (sqr1 == num2) Console.WriteLine("Да");
else if (sqr2 == num1) Console.WriteLine("Да");
else Console.WriteLine("Нет");