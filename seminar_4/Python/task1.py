# Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
# 7 -> 28
# 4 -> 10
# 8 -> 36


def SumNumbers(number):
    sum = 0

    for i in range(1, number + 1):
        sum += i
    
    return sum

num = int(input("Введите число: "))
print(num, SumNumbers(num))
