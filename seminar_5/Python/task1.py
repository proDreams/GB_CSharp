# Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
# Найдите сумму отрицательных и положительных элементов массива.
# Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

from random import randint

def FindSum(array):
    pos = 0
    neg = 0
    for i in array:
        if i > 0:
            pos += i
        else:
            neg += i
    return pos, neg

array_numbers = [randint(-9, 9) for _ in range(12)]
positive, negative = FindSum(array_numbers)
print(array_numbers)
print(f"Сумма отрицательных: {negative}.")
print(f"Сумма положительных: {positive}.")