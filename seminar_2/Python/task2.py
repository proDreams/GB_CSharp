# 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
# 456 -> 46
# 782 -> 72
# 918 -> 98

from random import randint

num = randint(100, 1000)
first = num // 100 * 10
third = num % 10
print(num, first + third)
