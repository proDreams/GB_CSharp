# Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
# 3, 5 -> 243 (3⁵)
# 2, 4 -> 16

def GetPow(first, second):
    result = 1
    for _ in range(second):
        result *= first

    return result


first_num = int(input("Введите первое число: "))
second_num = int(input("Введите второе число: "))
print(f"{first_num} {second_num} = {GetPow(first_num, second_num)}")
