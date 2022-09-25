# Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
# Например, на выходе получается вот такой массив:
# 01 02 03 04
# 12 13 14 05
# 11 16 15 06
# 10 09 08 07
from random import randint


def spiral(matrix, row, column, l_row, l_column):
    last_row = l_row - 1
    last_column = l_column - 1
    point = 1

    while row <= last_row and column <= last_column:
        for i in range(column, last_column + 1):
            matrix[row][i] = point
            point += 1
        row += 1

        for i in range(row, last_row + 1):
            matrix[i][last_column] = point
            point += 1
        last_column -= 1

        if row <= last_row and column <= last_column:
            for i in range(last_column, column - 1, - 1):
                matrix[last_row][i] = point
                point += 1
            last_row -= 1

            for i in range(last_row, row - 1, - 1):
                matrix[i][column] = point
                point += 1
            column += 1
    return matrix


rows, columns = int(input('Введите количество строк: ')), int(
    input('Введите количество столбцов: '))
matrix_array = [[0 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
start_row, start_column = 0, 0
print(*spiral(matrix_array, start_row, start_column, rows, columns), sep='\n')
