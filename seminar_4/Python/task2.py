# Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
# 456 -> 3
# 78 -> 2
# 89126 -> 5

def CountNumbers(number):
    result = 0
    while number > 0:
        result += 1
        number //= 10

    return result


num = int(input("Введите число: "))
print(num, CountNumbers(num))
