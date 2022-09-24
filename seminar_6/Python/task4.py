# Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
# Если N = 5 -> 0 1 1 2 3
# Если N = 3 -> 0 1 1
# Если N = 7 -> 0 1 1 2 3 5 8

def Fibonacci(fib):
    result = [0, 1]
    if fib == 0 or fib == 1:
        return 0
    for i in range(2, fib):
        result.append(result[i - 2] + result[i - 1])
    return result


fib_num = int(input("Введите число: "))
print(Fibonacci(fib_num))
