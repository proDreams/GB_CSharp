// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] ChangeArray(int[] array)
{
    var random = new Random();
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = random.Next(0, 2);
    }
    return array;
}

int[] arr = new int[8];
int[] newArray = ChangeArray(arr);
Console.WriteLine($"[{String.Join(", ", newArray)}]");

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}");
//         if (i < array.Length - 1) Console.Write(", ");
//     }
//     Console.Write("]");
// }
// PrintArray(newArray);
