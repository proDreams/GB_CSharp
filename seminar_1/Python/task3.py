# 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
# 3 -> Среда
# 5 -> Пятница

# Версия через условия
week_num = int(input("Введите номер дня недели: "))
if 0 < week_num < 8:
    if week_num == 1:
        print("Понедельник")
    elif week_num == 2:
        print("Вторник")
    elif week_num == 3:
        print("Среда")
    elif week_num == 4:
        print("Четверг")
    elif week_num == 5:
        print("Пятница")
    elif week_num == 6:
        print("Суббота")
    elif week_num == 7:
        print("Воскресенье")
else:
    print("Такого дня в неделе нет")


# Версия через массив
week = ["Понедельник", "Вторник", "Среда",
        "Четверг", "Пятница", "Суббота", "Воскресенье"]
week_num = int(input("Введите номер дня недели: "))
if 0 < week_num < 8:
    print(week[week_num - 1])
else:
    print("Такого дня в неделе нет")
