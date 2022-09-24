# Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
# 5, 0, 20 -> [1, 2, 5, 7, 19]
# 3, 1, 35 -> [6, 1, 33]

from random import randint

array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
