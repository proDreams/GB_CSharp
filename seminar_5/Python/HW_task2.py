# Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
# [3, 7, 23, 12] -> 19
# [-4, -6, 89, 6] -> 0

from random import randint

def OddPosSum(array):
    sum = 0
    for i in range(1, len(array), 2):
        sum += array[i]

    return sum


array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
print(OddPosSum(result_array))
