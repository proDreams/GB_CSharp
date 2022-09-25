# Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
# M = 1; N = 15 -> 120
# M = 4; N = 8. -> 30
def NumbersRec(m, n):
    if m == n:
         return n
    else:
        return m + NumbersRec(m + 1, n)


num_m = int(input("Введите первое число: "))
num_n = int(input("Введите второе число: "))
print(NumbersRec(num_m, num_n))