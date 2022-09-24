# Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
# заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
# b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

def CrossPoint(array):
    points = []
    points.append((array[1][1] - array[0][1]) / (array[0][0] - array[1][0]))
    points[0] = points[0]
    points.append(array[0][0] * points[0] + array[0][1])
    points[1] = points[1]
    return points

straight = [[], []]
straight[0].append(int(input("Введите координату k1: ")))
straight[0].append(int(input("Введите координату b1: ")))
straight[1].append(int(input("Введите координату k2: ")))
straight[1].append(int(input("Введите координату b2: ")))

if straight[0][0] == straight[1][0] and straight[0][1] != straight[1][1]:
    print("Прямые паралельны")
elif straight[0][0] == straight[1][0] and straight[0][1] == straight[1][1]:
    print("Прямые совпадают")
else:
    crossPoints = CrossPoint(straight)
    print(f"Точки пересечения: {crossPoints}")
