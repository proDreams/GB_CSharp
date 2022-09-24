# Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
# [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
# [1,2,2,3,2] -> [3, 2, 2, 2, 1]

from random import randint


def BubbleSort(array, len):
    for i in range(len):
        for j in range(i + 1, len):
            if array[i] > array[j]:
                array[i], array[j] = array[j], array[i]


array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
BubbleSort(result_array, array_len)
print(result_array)
