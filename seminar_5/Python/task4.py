# Задача 35: Задайте одномерный массив из 123 случайных чисел. 
# Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
# Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
# [5, 18, 123, 6, 2] -> 1
# [1, 2, 3, 6, 2] -> 0
# [10, 11, 12, 13, 14] -> 5

from random import randint

def CountNumbers(array):
    counter = 0
    for i in array:
        if 9 < i < 100:
            counter += 1
    
    return counter

array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
print(CountNumbers(result_array))