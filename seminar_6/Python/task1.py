# Напишите программу, которая перевернёт одномерный массив 
# (последний элементбудет на первом месте, а первый - на последнем и т.д.)
# [1 2 3 4 5] -> [5 4 3 2 1]
# [6 7 3 6] -> [6 3 7 6]

from random import randint

# Функцией
def ReverseArray(array):
    size = len(array) // 2
    for i in range(size):
        array[i], array[-1 - i] = array[-1 - i], array[i]

array_len = int(input("Введите размер массива: "))
rand_start = int(input("Введите начало диапазона: "))
rand_end = int(input("Введите конец диапазона: "))
result_array = [randint(rand_start, rand_end) for _ in range(array_len)]
print(result_array)
ReverseArray(result_array)
print(result_array)
# Срезом
# print(result_array[::-1])