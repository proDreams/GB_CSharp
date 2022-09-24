# Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
# 452 -> 11
# 82 -> 10
# 9012 -> 12

def SumNumbers(number):
    result = 0

    while number > 0:
        result += number % 10
        number //= 10

    return result


num = int(input("Введите число: "))
print(f"Сумма цифр в числе {num} - {SumNumbers(num)}")
