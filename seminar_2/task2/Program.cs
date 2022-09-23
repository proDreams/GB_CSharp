// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int randNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {randNum}");
int firstNum = randNum / 100;
int thirdNum = randNum % 10;
Console.WriteLine(firstNum * 10 + thirdNum);
// Console.WriteLine("$"{firstNum}{thirdNum}"");