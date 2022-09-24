# Задача 37: Найдите произведение пар чисел в одномерном массиве. 
# Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
# [1 2 3 4 5] -> 5 8 3
# [6 7 3 6] -> 36 21

from random import randint

def ProductionArray(array):
    size = len(array) // 2
    result = []
    for i in range(size):
        result.append(array[i] * array[-i - 1])
    if len(array) % 2 != 0:
        result.append(array[size])
    return result

array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
print(ProductionArray(result_array))