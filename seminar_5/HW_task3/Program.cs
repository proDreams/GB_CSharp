// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        res[i] /= 100;
    }
    return res;
}

double FindMax(double[] array)
{
    double result = array[0];
    foreach (double el in array)
    {
        if (el > result) result = el;
    }
    return result;
}

double FindMin(double[] array)
{
    double result = array[0];
    foreach (double el in array)
    {
        if (el < result) result = el;
    }
    return result;
}

Console.Write("Введите длинну массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
double[] newArray = GetArray(arraySize, arrayStart, arrayEnd);
Console.WriteLine($"Массив: [{String.Join(" ", newArray)}]");
double maxElement = FindMax(newArray);
double minElement = FindMin(newArray);
double minMax = maxElement - minElement;
Console.WriteLine($"Минимальный элемент массива: {minElement}");
Console.WriteLine($"Максимальный элемент массива: {maxElement}");
Console.WriteLine($"Разница между максимальным и минимальным: {minMax:f2}");