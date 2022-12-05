# 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
# 78 -> 8
# 12-> 2
# 85 -> 8

from random import randint

num = randint(10, 100)
first = num // 10
second = num % 10
print(max(first, second))
