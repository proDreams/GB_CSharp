# Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
# A = 3; B = 5 -> 243 (3⁵)
# A = 2; B = 3 -> 8
def PowNumber(a, b):
    if b != 1:
        a *= PowNumber(a, b - 1)
    return a

num_a = int(input("Введите первое число: "))
num_b = int(input("Введите второе число: "))
print(PowNumber(num_a, num_b))