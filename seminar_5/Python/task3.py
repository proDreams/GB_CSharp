# Задача 33: Задайте массив. Напишите программу, которая определяет,
# присутствует ли заданное число в массиве.
# 4; массив [6, 7, 19, 345, 3] -> нет
# 3; массив [6, 7, 19, 345, 3] -> да

from operator import truediv
from random import randint


def SearchNumber(array, num):
    for i in array:
        if i == num:
            return True
    return False


array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
search_num = int(input("Введите число для поиска: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
if SearchNumber(result_array, search_num):
    print(f"Число {search_num} есть в массиве")
else:
    print(f"Числа {search_num} нет в массиве")
