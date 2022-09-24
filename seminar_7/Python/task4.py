# Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
# Например, задан массив:
# 1 4 7 2
# 5 9 2 3
# 8 4 2 4

from random import randint


def DiagSum(array, row):
    sum = 0
    for i in range(row):
        sum += array[i][i]
    return sum


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
print(DiagSum(matrix_array, rows))
