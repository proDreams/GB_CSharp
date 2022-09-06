// Напишите программу, которая перевернёт одномерный массив 
// (последний элементбудет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReverseArray(int[] array)
{
    int size = array.Length / 2;
    for (int i = 0; i < size; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

Console.Write("Введите длинну массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[] newArray = GetArray(arraySize, arrayStart, arrayEnd);
Console.WriteLine($"Массив: [{String.Join(", ", newArray)}]");
ReverseArray(newArray);
Console.WriteLine($"Массив: [{String.Join(", ", newArray)}]");
