// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int[] ChangeArray(int[] array, int start, int end)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(start, end);
    }
    return array;
}

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arraySize];

Console.Write("Введите начальное число диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());

int[] newArray = ChangeArray(arr, arrayStart, arrayEnd);
Console.WriteLine($"[{String.Join(", ", newArray)}]");