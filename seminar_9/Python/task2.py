# Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
# M = 1; N = 5 -> "1, 2, 3, 4, 5"
# M = 4; N = 8 -> "4, 6, 7, 8"

def NumbersRec(m, n):
    print(m, end='')
    if m < n:
        print(", ", end='')
        NumbersRec(m + 1, n)

num_m = int(input("Введите первое число: "))
num_n = int(input("Введите второе число: "))
NumbersRec(num_m, num_n)