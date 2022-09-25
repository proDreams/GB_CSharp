# Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае,
# если это невозможно, программа должна вывести сообщение для пользователя.
from random import randint

def SwapRowsAndColumns(array, row, col):
    result_array = [[0 for _ in range(col)] for _ in range(row)]
    if row == col:
        for i in range(row):
            for j in range(col):
                result_array[j][i] = array[i][j]
        return result_array
    else:
        print("Невозможно поменять местами строки и столбцы")
        return array



rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
print()
changed_array = SwapRowsAndColumns(matrix_array, rows, columns)
print(*changed_array, sep='\n')