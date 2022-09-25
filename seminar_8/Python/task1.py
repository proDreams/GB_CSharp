# Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
from random import randint


def ChangeArrayRows(array, col):
    for i in range(col):
        array[0][i], array[-1][i] = array[-1][i], array[0][i]


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
ChangeArrayRows(matrix_array, columns)
print()
print(*matrix_array, sep='\n')
