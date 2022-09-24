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
    match symbol:
        case 'I':
            return 1
        case 'V':
            return 5
        case 'X':
            return 10
        case 'L':
            return 50
        case 'C':
            return 100
        case 'D':
            return 500
        case 'M':
            return 1000
        case _:
            return 0


romanNumber = input("Введите Римское число: ")
print(RomanToArabic(romanNumber))
