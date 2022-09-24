# Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
# Например, задан массив:
# 1 4 7 2
# 5 9 2 3
# 8 4 2 4
# Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

from random import randint

def MeanColumns(array, row, col):
    result = []
    mean = 0

    for i in range(row):
        for j in range(col):
            mean += array[i][j]
        result.append(mean / col)
        mean = 0
    return result

rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
print()
print(*MeanColumns(matrix_array, rows, columns), sep='\n')