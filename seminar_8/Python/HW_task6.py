# Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, 
# которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
# Нельзя использовать встроенные функции библиотеки Math!

def FindSQRT(num):
    result = 0
    for i in range(1, num):
        if i * i <= num:
            continue
        else:
            result = i - 1
            return result

number = int(input("Введите число: "))
print(FindSQRT(number))