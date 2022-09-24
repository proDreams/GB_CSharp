# Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
# и возвращает позицию этого элемента или же указание, что такого элемента нет.
# Например, задан массив:
# 1 4 7 2
# 5 9 2 3
# 8 4 2 4
# 17 -> такого числа в массиве нет
from random import randint


def SearchNumber(array, row, col, num):
    for i in range(row):
        for j in range(col):
            if array[i][j] == num:
                return f"Число {num} находится на позиции: {[i, j]}"
    return f"Числа {num} нет в массиве"


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
search_num = int(input("Введите число для поиска: "))
matrix_array = [[randint(rand_start, rand_end)
                 for _ in range(columns)] for _ in range(rows)]
print(*matrix_array, sep='\n')
print(SearchNumber(matrix_array, rows, columns, search_num))
