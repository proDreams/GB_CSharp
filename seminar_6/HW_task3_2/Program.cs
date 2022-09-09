// Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

string BypassMatrix(int row, int column, int[,] array)
{
    string result = String.Empty;
    int lastRow = 0, lastColumn = array.GetLength(1) - 1;

    while (row >= lastRow && column <= lastColumn)
    {
        for (int i = column; i <= lastColumn; i++)
        {
            result += array[row, i] + " ";
        }
        row--;

        for (int i = row; i >= lastRow; i--)
        {
            result += array[i, lastColumn] + " ";
        }
        lastColumn--;

        if (row >= lastRow && column <= lastColumn)
        {
            for (int i = lastColumn; i >= column; i--)
            {
                result += array[lastRow, i] + " ";
            }
            lastRow++;


            for (int i = lastRow; i <= row; i++)
            {
                result += array[i, column] + " ";
            }
            column++;
        }
    }
    return result;
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    int num = 1;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = num++;
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

Console.Write("Введите количество строк: ");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = GetMatrix(arrayRows, arrayColumns);
PrintMatrix(newMatrix);
Console.WriteLine(BypassMatrix(arrayRows - 1, 0, newMatrix));