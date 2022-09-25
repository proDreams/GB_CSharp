# Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
# Массив размером 2 x 2 x 2
# 66(0,0,0) 25(0,1,0)
# 34(1,0,0) 41(1,1,0)
# 27(0,0,1) 90(0,1,1)
# 26(1,0,1) 55(1,1,1)

from random import randint

def Print_3D_Matrix(array, row, col, dep):
    for i in range(dep):
        for j in range(row):
            for k in range(col):
                print(f"{array[i][j][k]}({i},{j},{k})", end=" ")
            print()


rows = int(input('Введите количество строк: '))
columns = int(input('Введите количество столбцов: '))
depth = int(input('Введите глубину: '))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
matrix_array = [[[randint(rand_start, rand_end) for _ in range(columns)] for _ in range(rows)] for _ in range(depth)]
print(*matrix_array, sep='\n')
print()
Print_3D_Matrix(matrix_array, rows, columns, depth)