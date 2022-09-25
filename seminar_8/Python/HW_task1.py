# Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
# Например, задан массив:
# 1 4 7 2
# 5 9 2 3
# 8 4 2 4
# В итоге получается вот такой массив:
# 7 4 2 1
# 9 5 3 2
# 8 4 4 2

from random import randint


def RowSort(array, row, col):
    for i in range(row):
        for j in range(col):
            for k in range(j + 1, col):
                if array[i][j] < array[i][k]:
                    array[i][j], array[i][k] = array[i][k], array[i][j]


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
print()
RowSort(matrix_array, rows, columns)
print(*matrix_array, sep='\n')
