# Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
# [3 7 22 2 78] -> 76

from random import uniform

def FindMinMax(array):
    max = array[0]
    min = array[1]
    for i in array:
        if i > max:
            max = i
        elif i < min:
            min = i
    
    return round(max - min, 2)

array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [round(uniform(rand_start, rand_end), 2) for _ in range(array_len)]
print(result_array)
print(FindMinMax(result_array))