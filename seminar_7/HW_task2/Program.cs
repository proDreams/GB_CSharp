// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetMatrix(int rows, int columns, int start, int end)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindElement(int[,] array, int numberToSearch)
{
    int[] status = {-1, -1};

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == numberToSearch)
            {
                status[0] = i;
                status[1] = j;
                return status;
            }
        }
    }
    return status;
}

Console.Write("Введите количество строк: ");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало диапазона: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для поиска: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = GetMatrix(arrayRows, arrayColumns, arrayStart, arrayEnd);
Console.WriteLine("Массив:");
PrintMatrix(newMatrix);
int[] findElement = FindElement(newMatrix, searchNumber);
if (findElement[0] == -1 && findElement[1] == -1) Console.WriteLine($"Числа {searchNumber} нет в массиве");
else Console.WriteLine($"Позиция числа {searchNumber}: Строка {findElement[0]}, столбец {findElement[1]}");