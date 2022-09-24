# Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
# Например, изначально массив выглядел вот так:
# 1 4 7 2
# 5 9 2 3
# 8 4 2 4
# Новый массив будет выглядеть вот так:
# 1 4 49 2
# 5 81 2 9
# 64 4 4 4

from random import randint

def ChangeArray(array, row, column):
    for i in range(row):
        if i % 2 == 0:
            for j in range(column):
                if j % 2 == 0:
                    array[i][j] = pow(array[i][j], 2)


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
ChangeArray(matrix_array, rows, columns)
print()
print(*matrix_array, sep='\n')
