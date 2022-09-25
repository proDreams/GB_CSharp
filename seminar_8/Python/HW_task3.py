# Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
# Например, даны 2 матрицы:
# 2 4 | 3 4
# 3 2 | 3 3
# Результирующая матрица будет:
# 18 20
# 15 18

from random import randint


def ProductionMatrix(firstMatrix, secondMatrix, row, col):
    prod = [[0 for _ in range(col)] for _ in range(row)]
    for i in range(row):
        for j in range(col):
            for k in range(col):
                prod[i][j] += firstMatrix[i][k] * secondMatrix[k][j]
    return prod


rows_a = int(input('Введите количество строк первой матрицы: '))
columns_a = int(input('Введите количество столбцов первой матрицы: '))
rows_b = int(input('Введите количество строк второй матрицы: '))
columns_b = int(input('Введите количество столбцов второй матрицы: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_a = [[randint(rand_start, rand_end)
             for _ in range(columns_a)] for _ in range(rows_a)]
matrix_b = [[randint(rand_start, rand_end)
             for _ in range(columns_b)] for _ in range(rows_b)]
print('Первая матрица:', *matrix_a, sep='\n')
print()
print('Вторая матрица:', *matrix_b, sep='\n')
print()
if columns_a == rows_b:
    print('Произведение матриц:', *ProductionMatrix(matrix_a,
          matrix_b, rows_a, columns_b), sep='\n')
else:
    print("Нельзя найти произведение матриц.")
