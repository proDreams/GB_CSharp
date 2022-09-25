# Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
# Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
# Пример правильной скобочной последовательности: (), ()[]{}
# Пример неправильной: (], ({)}
# Написать программу, которая определяет правильная ли скобочная последовательность была введена
from dataclasses import replace


def Brackets(seq):
    changes = 1
    if len(seq) % 2 != 0:
        return False
    while changes > 0:
        changes = 0
        for i in range(len(seq)):
            if i + 1 > len(seq) - 1:
                break
            temp = seq[i] + seq[i + 1]
            if BracketsTable(temp):
                seq = seq[:i] + seq[i + 2:]
                changes += 1
    if len(seq) > 0:
        return False
    else:
        return True


def BracketsTable(bracket):
    match bracket:
        case "()":
            return True
        case "{}":
            return True
        case "[]":
            return True
        case _:
            return False


sequence = input("Введите скобочную последовательность: ")
if Brackets(sequence):
    print("Правильная последовательность")
else:
    print("Неправильная последовательность")
