# Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
# 2, 3, 7 -> 7
# 44 5 78 -> 78
# 22 3 9 -> 22

num_a = int(input("Введите первое число: "))
num_b = int(input("Введите второе число: "))
num_c = int(input("Введите третье число: "))
max = num_a

if num_b > max:
    max = num_b
    if num_c > max:
        max = num_c
elif num_c > max:
    max = num_c

print(f"Число {max} больше всех")
