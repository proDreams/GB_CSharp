# Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
# 0, 7, 8, -2, -2 -> 2
# 1, -7, 567, 89, 223-> 3

def CountNumbers(count):
    sum = 0
    for i in range(1, count + 1):
        temp = int(input(f"Введите {i} число: "))
        if temp > 0:
            sum += temp
    return sum


count_num = int(input("Введите количество чисел: "))
print(CountNumbers(count_num))
