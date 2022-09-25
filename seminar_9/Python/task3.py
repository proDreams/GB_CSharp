# Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
# 453 -> 12
# 45 -> 9
def SumRec(n):
    if n == 0:
        return n
    else:
        return n % 10 + SumRec(n // 10)


num = int(input("Введите число: "))
print(SumRec(num))
