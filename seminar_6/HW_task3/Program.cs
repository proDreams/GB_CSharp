// Напишите программу, которая реализует обход введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

//Работет только с массивами 3х3.
void BypassMatrix(int[] start, int[,] array, int[] result, int counter = 0, int dimension = 0)
{
    while (counter <= array.Length)
    {
        if (dimension == 0)
        {
            for (int j = start[1]; j < array.GetLength(0); j++)
            {
                result[counter] = array[start[0], j];
                counter++;
                start[1] = j;
            }
            dimension = 1;
        }
        else if (dimension == 1)
        {
            for (int i = start[0] - 1; i >= 0; i--)
            {
                result[counter] = array[i, start[1]];
                counter++;
                start[0] = i;
            }
            dimension = 2;
        }
        else if (dimension == 2)
        {
            for (int j = start[1] - 1; j >= 0; j--)
            {
                result[counter] = array[start[0], j];
                counter++;
                start[1] = j;
            }
            dimension = 3;
        }
        else if (dimension == 3)
        {
            for (int i = start[0] + 1; i < array.GetLength(1) - 1; i++)
            {
                result[counter] = array[i, start[1]];
                counter++;
                start[0] = i;
            }
            dimension = 4;
        }
        else if (dimension == 4)
        {
            for (int j = start[1] + 1; j < array.GetLength(1) - 1; j++)
            {
                result[counter] = array[start[0], j];
                counter++;
                start[1] = j;
            }
            break;
        }
    }
}

int[,] matrix = {{1, 2, 3},
                 {4, 5, 6},
                 {7, 8, 9}};
int[] startPosition = { 2, 0 };
int[] resultArray = new int[matrix.Length];
BypassMatrix(startPosition, matrix, resultArray);
Console.WriteLine(String.Join(" ", resultArray));