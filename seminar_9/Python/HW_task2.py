# Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
# m = 2, n = 3 -> A(m,n) = 9
def Ackermann(m, n):
    if m > 0 and n > 0:
        return Ackermann(m - 1, Ackermann(m, n - 1))
    elif m > 0 & n == 0:
        return Ackermann(m - 1, 1)
    else:
        return n + 1


num_m = int(input("Введите первое число: "))
num_n = int(input("Введите второе число: "))
print(Ackermann(num_m, num_n))