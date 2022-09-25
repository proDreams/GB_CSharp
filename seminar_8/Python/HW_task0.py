# Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

def Triangle(num):
    rows = [[1], [1, 1]]
    for i in range(1, num):
        t = [1]
        for j in range(i):
            t.append(rows[i][j] + rows[i][j + 1])
        t.append(1)
        rows.append(t)
    return rows


def PrintTriangle(array, rows):
    spaces = rows - 1
    for i in range(rows):
        for j in range(spaces + 1):
            if j < spaces:
                print('   ', end='')
            elif j == spaces:
                print(*array[i], sep='    ', end='')
        spaces -= 1
        print()


triangle_size = int(input("Введите размер треугольника: "))
triangle = Triangle(triangle_size)
PrintTriangle(triangle, triangle_size)
