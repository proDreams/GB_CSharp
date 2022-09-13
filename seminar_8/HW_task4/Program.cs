﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Get3DimensionMatrix(int rows, int columns, int layers)
{
    int[,,] result = new int[rows, columns, layers];
    int num = 10;

    for (int i = 0; i < layers; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                result[i, j, k] = num;
                num++;
            }
        }
    }
    return result;
}

void Print3DimensionMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество строк: ");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество слоёв: ");
int arrayLayers = Convert.ToInt32(Console.ReadLine());
int[,,] matrix3D = Get3DimensionMatrix(arrayRows, arrayColumns, arrayLayers);
Print3DimensionMatrix(matrix3D);