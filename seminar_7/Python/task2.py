# Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
# Aₘₙ = m+n. Выведите полученный массив на экран.
# m = 3, n = 4
# 0 1 2 3
# 1 2 3 4
# 2 3 4 5

def FillArray(array, row, column):
    for i in range(row):
        for j in range(column):
            array[i][j] = i + j

rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
matrix_array = [[0 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
FillArray(matrix_array, rows, columns)
print(*matrix_array, sep='\n')