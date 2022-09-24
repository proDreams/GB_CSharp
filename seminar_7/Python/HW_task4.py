# Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
# III -> 3
# LVIII -> 58
# MCMXCIV -> 1994

def RomanToArabic(roman):
    result = 0
    firstSymbol = 0
    secondSymbol = 0
    position = len(roman) - 1
    while position >= 0:
        firstSymbol = SymbolsTable(roman[position])
        if position - 1 >= 0:
            secondSymbol = SymbolsTable(roman[position - 1])
        else:
            secondSymbol = 0

        if firstSymbol != secondSymbol:
            if secondSymbol > firstSymbol:

                result += firstSymbol + secondSymbol
                position -= 2
            else:

                result += firstSymbol - secondSymbol
                position -= 2
        else:

            result += firstSymbol
            position -= 1

    return result


def SymbolsTable(symbol):
    if symbol == 'I':
        return 1
    elif symbol == 'V':
        return 5
    elif symbol == 'X':
        return 10
    elif symbol == 'L':
        return 50
    elif symbol == 'C':
        return 100
    elif symbol == 'D':
        return 500
    else:
        return 1000


romanNumber = input("Введите Римское число: ")
print(RomanToArabic(romanNumber))
