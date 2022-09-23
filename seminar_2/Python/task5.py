# 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
# 5, 25  ->  да
# -4, 16  ->  да
# 25, 5  ->  да
# 8,9  ->  нет

first_num = int(input("Введите первое число: "))
second_num = int(input("Введите второе число: "))
first_sqr = first_num * first_num
second_sqr = second_num * second_num

if first_sqr == second_num or second_sqr == first_num:
    print("Числа кратны")
else:
    print("Числа не кратны")
