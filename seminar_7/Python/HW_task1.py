# Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
# m = 3, n = 4.
# 0,5 7 -2 -0,2
# 1 -3,3 8 -9,9
# 8 7,8 -7,1 9

from random import uniform

rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[round(uniform(rand_start, rand_end), 2)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
