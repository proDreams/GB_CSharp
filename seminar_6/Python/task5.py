# Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

from random import randint

def ArrayCopy(array):
    result = []
    for i in array:
        result.append(i)
    return result

array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
new_array = ArrayCopy(result_array)
print(new_array)