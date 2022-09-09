// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.

// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

int RomanToArabic(string roman)
{
    string symbols = roman;
    int result = 0;
    int firstSymbol = 0;
    int secondSymbol = 0;
    int position = symbols.Length - 1;
    while (position >= 0)
    {
        firstSymbol = SymbolsTable(symbols[position]);
        if (position - 1 >= 0) secondSymbol = SymbolsTable(symbols[position - 1]);
        else secondSymbol = 0;

        if (firstSymbol != secondSymbol)
        {
            if (secondSymbol > firstSymbol)
            {
                result += firstSymbol + secondSymbol;
                position -= 2;
            }
            else
            {
                result += firstSymbol - secondSymbol;
                position -= 2;
            }
        }
        else
        {
            result += firstSymbol;
            position--;
        }
    }
    return result;
}

int SymbolsTable(char symbol)
{
    switch (symbol)
    {
        case 'I': return 1;
        case 'V': return 5;
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
        default: return 0;
    }
}

Console.Write("Введите римское число: ");
string romanNumber = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"Римское число {romanNumber} в Арабских числах: {RomanToArabic(romanNumber)}");