# Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
# Например, задан массив:
# 1 4 7 2
# 5 9 2 3
# 8 4 2 4
# 5 2 6 7
# Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
from random import randint


def RowSum(array, row, col):
    sum = [0 for _ in range(col)]
    for i in range(row):
        for j in range(col):
            sum[i] += array[i][j]
    return sum


def FindMinimumRow(array):
    min_index = 0
    for i in range(len(array)):
        if array[i] < array[min_index]:
            min_index = i
    return min_index


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
sum_array = RowSum(matrix_array, rows, columns)
print(f"Минимальная сумма элементов в строке: {FindMinimumRow(sum_array)}")
