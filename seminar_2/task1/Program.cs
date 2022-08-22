int randNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {randNum}");
int firstNum = randNum / 10;
int secondNum = randNum % 10;
int max = firstNum;
if (max < secondNum) max = secondNum;
Console.WriteLine($"Максимальное число: {max}");