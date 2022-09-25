# Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
# N = 5 -> "1, 2, 3, 4, 5"
# N = 6 -> "1, 2, 3, 4, 5, 6"

def NumbersRec(n, current = 1):
    print(current, end='')
    if current < n:
        print(", ", end='')
        NumbersRec(n, current + 1)

num = int(input("Введите число: "))
NumbersRec(num)