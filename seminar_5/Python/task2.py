# Задача 32: Напишите программу замена элементов массива:
# положительные элементы замените на соответствующие отрицательные, и наоборот.
# [-4, -8, 8, 2] -> [4, 8, -8, -2]

from random import randint


def ChangeArray(array, len):
    for i in range(len):
        array[i] = -array[i]


array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
ChangeArray(result_array, array_len)
print(result_array)
