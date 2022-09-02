// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int EvenNumbers(int[] array)
{
    int result = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) result++;
    }
    return result;
}


Console.Write("Введите длинну массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(arraySize, arrayStart, arrayEnd);
Console.WriteLine($"Массив: [{String.Join(", ", newArray)}]");
int evenNumbers = EvenNumbers(newArray);
Console.WriteLine($"Чётных чисел в массиве: {evenNumbers}");