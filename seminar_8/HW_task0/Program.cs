// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

void PrintTriangle(int[][] array, int rows)
{
    int spaces = rows - 1;
    for (int i = 0; i <= rows; i++)
    {
        for (int j = 0; j <= spaces + 1; j++)
        {
            if (j < spaces) Console.Write(" ");
            else if (j <= spaces) Console.Write(String.Join(" ", array[i]));
            else break;
        }
        spaces--;
        Console.WriteLine();
    }
}

void FillTriangle(int[][] triangle, int rows)
{
    for (int i = 0; i < rows; i++)
    {
        triangle[i][0] = 1;
        triangle[i][triangle[i].Length - 1] = 1;
        for (int j = 1; j < triangle[i].Length - 1; j++)
        {
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
        }
    }
}

void InitiateTriangleArray(int[][] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new int[i + 1];
    }
}

Console.Write("Введите размер треугольника: ");
int triangleRows = Convert.ToInt32(Console.ReadLine());
int[][] triangleArray = new int[triangleRows][];
InitiateTriangleArray(triangleArray);
FillTriangle(triangleArray, triangleRows);
PrintTriangle(triangleArray, triangleRows);
