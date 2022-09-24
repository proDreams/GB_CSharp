# Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
# m = 3, n = 4
# 1 4 8 19
# 5 -2 33 -2
# 77 3 8 1

from random import randint

rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
