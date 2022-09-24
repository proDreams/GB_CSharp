# Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
# [1,0,1,1,0,1,0,0]

from random import randint

array_numbers = [randint(0, 1) for _ in range(8)]
print(array_numbers)