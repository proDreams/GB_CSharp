# Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
# [345, 897, 568, 234] -> 2

from random import randint


def EvenNumbers(array):
    result = 0
    for i in array:
        if i % 2 == 0:
            result += 1
    
    return result


array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
print(EvenNumbers(result_array))