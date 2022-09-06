// Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

//Работает с любыми квадратными матрицами и матрицами с разным количеством строк.
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
    return result;
}

int[,] matrix = {{1, 2, 3, 11, 20},
                 {4, 5, 6, 12, 21},
                 {7, 8, 9, 13, 22},
                 {14, 15, 16, 17, 23},
                 {24, 25, 26, 27, 28}};
int startRow = 4, startColumn = 0;
Console.WriteLine(BypassMatrix(startRow, startColumn, matrix));