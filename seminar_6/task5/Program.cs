// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

Console.Write("Введите длинну массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(arraySize, arrayStart, arrayEnd);
Console.WriteLine($"Массив: [{String.Join(", ", newArray)}]");
Console.WriteLine($"Копия массива: [{String.Join(", ", CopyArray(newArray))}]");