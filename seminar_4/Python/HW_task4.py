# Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

def Tree(height):
    spaces = height - 1
    stars = 1
    for i in range(1, height + 1):
        for j in range(1, spaces + stars + 1):
            if j <= spaces:
                print(" ", end="")
            else:
                print("*", end="")
        spaces -= 1
        stars += 2
        print()


heightTree = int(input("Введите высоту: "))
Tree(heightTree)
