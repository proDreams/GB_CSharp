// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
using System.Diagnostics;

long GetArray1(int size, int maxValue)
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * maxValue;

    }
    stopwatch.Stop();
    // Console.WriteLine($"Вариант 1 - вещественное умножать на 10: {stopwatch.ElapsedMilliseconds} миллисекунды.");
    // Console.WriteLine($"Вариант 1 - вещественное умножать на 10: {stopwatch.ElapsedTicks} тактов.");
    return stopwatch.ElapsedTicks;
}

long GetArray2(int size, int minValue, int maxValue)
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        res[i] /= 10;
    }
    stopwatch.Stop();
    // Console.WriteLine($"Вариант 2 - целое делить на 10: {stopwatch.ElapsedMilliseconds} миллисекунды.");
    // Console.WriteLine($"Вариант 2 - целое делить на 10: {stopwatch.ElapsedTicks} тактов.");
    return stopwatch.ElapsedTicks;
}

long GetArray3(int size, int minValue, int maxValue)
{
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    stopwatch.Stop();
    // Console.WriteLine($"Вариант 3 - к целому прибавить вещественное: {stopwatch.ElapsedMilliseconds} миллисекунды.");
    // Console.WriteLine($"Вариант 3 - к целому прибавить вещественное: {stopwatch.ElapsedTicks} тактов.");
    return stopwatch.ElapsedTicks;
}


Console.Write("Введите длинну массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());

long[] newArray1 = new long[arraySize];
for (int i = 0; i < arraySize; i++)
{
    newArray1[i] = GetArray1(arraySize, arrayEnd);
}
Console.WriteLine($"Вариант 1 - вещественное умножать на 10: {newArray1.Average()} тактов.");

long[] newArray2 = new long[arraySize];
for (int i = 0; i < arraySize; i++)
{
    newArray1[i] = GetArray2(arraySize, arrayStart, arrayEnd);
}
Console.WriteLine($"Вариант 2 - целое делить на 10: {newArray1.Average()} тактов.");

long[] newArray3 = new long[arraySize];
for (int i = 0; i < arraySize; i++)
{
    newArray1[i] = GetArray3(arraySize, arrayStart, arrayEnd);
}
Console.WriteLine($"Вариант 3 - к целому прибавить вещественное: {newArray1.Average()} тактов.");
