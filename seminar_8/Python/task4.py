# Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
# на пересечении которых расположен наименьший элемент массива.
# Например, задан массив:
# 1 4 7 2
# 5 9 2 3
# 8 4 2 4
# 5 2 6 7
# Наименьший элемент - 1, на выходе получим следующий массив:
# 9 4 2
# 2 2 6
# 3 4 7
from random import randint


def FindMinimum(array, row, col):
    min = array[0][0]
    temp = [0, 0]
    for i in range(row):
        for j in range(col):
            if min > array[i][j]:
                min = array[i][j]
                temp[0], temp[1] = i, j
    return temp


def ChangeArray(array, row, col, min_array):
    result_array = [[0 for _ in range(col - 1)] for _ in range(row - 1)]
    k, l = 0, 0

    for i in range(row):
        if i != min_array[0]:
            for j in range(col):
                if j != min_array[1]:
                    result_array[l][k] = array[i][j]
                    k += 1
            k = 0
            l += 1
    return result_array


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
min_index = FindMinimum(matrix_array, rows, columns)
print()
print(*ChangeArray(matrix_array, rows, columns, min_index), sep='\n')
