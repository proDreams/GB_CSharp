Console.Write("Введите число: ");
int i = int.Parse(Console.ReadLine());
int result = i * i;
Console.WriteLine($"Результат = {result}");
Console.WriteLine($"Результат = {Math.Pow(i, 2)}"); // Возведение в степень с помошью библиотеки Math = Math.Pow(переменная, степень)