# Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
# 3 -> 1, 8, 27 
# 5 -> 1, 8, 27, 64, 125

from math import pow

num = int(input("Введите число: "))

if num > 0:
    for i in range(1, num + 1):
        print(pow(i, 3), end="")
        if i < num:
            print(", ", end="")
else:
    print("Введено неверное число")