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
    if (symbol == 'I') return 1;
    else if (symbol == 'V') return 5;
    else if (symbol == 'X') return 10;
    else if (symbol == 'L') return 50;
    else if (symbol == 'C') return 100;
    else if (symbol == 'D') return 500;
    else return 1000;
}

string romanNumber = Console.ReadLine() ?? string.Empty;
Console.WriteLine(RomanToArabic(romanNumber));