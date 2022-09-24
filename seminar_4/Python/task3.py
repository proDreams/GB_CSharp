# Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
# 4 -> 24
# 5 -> 120

def ProdNumbers(number):
    result = 1
    for i in range(1, number + 1):
        result *= i

    return result


num = int(input("Введите число: "))
print(num, ProdNumbers(num))
