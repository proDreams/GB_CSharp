Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int cond1 = num % 7;
int cond2 = num % 23;

if (cond1 == 0 && cond2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");