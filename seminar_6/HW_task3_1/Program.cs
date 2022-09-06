// Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

// Работает только с массивами в 3 ряда и разным количеством столбцов.
void BypassMatrix(int row, int col, int[,] array, int[] result, int count)
{
    if (count < array.Length)
    {
        result[count] = array[row, col];
        count++;
        // Console.WriteLine($"row = {row}, col = {col}, count = {count}"); // Вывод для тестирования
        if (col < array.GetLength(1) - 1 && row != 0) BypassMatrix(row, col + 1, array, result, count);
        else if (row > 0) BypassMatrix(row - 1, col, array, result, count);
        else if (col > 0) BypassMatrix(row, col - 1, array, result, count);
        else if (row < array.GetLength(0)) BypassMatrix(row + 1, col, array, result, count);
    }
}

int[,] matrix = {{1, 2, 3},
                 {4, 5, 6},
                 {7, 8, 9}};
int startRow = 2;
int startColumn = 0;
int[] resultArray = new int[matrix.Length];
int counter = 0;
BypassMatrix(startRow, startColumn, matrix, resultArray, counter);
Console.WriteLine(String.Join(" ", resultArray));
