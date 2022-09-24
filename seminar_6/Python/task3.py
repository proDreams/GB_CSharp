# Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# 45 -> 101101
# 3 -> 11
# 2 -> 10

def DecToBinary(dec):
    result = ''
    while dec > 0:
        if dec % 2 == 1:
            result += '1'
        else:
            result += '0'
        dec //= 2
    return result[::-1]


dec_num = int(input("Введите число: "))
print(DecToBinary(dec_num))
