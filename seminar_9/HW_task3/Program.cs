// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

bool Brackets(string seq)
{
    int size = seq.Length;

    if (size % 2 != 0) return false;
    else
    {
        for (int i = 0; i < size / 2; i++)
        {
            char open = seq[i];
            char close = BracketsTable(seq[i]);
            if (close != seq[size - 1 - i]) return false;
        }
        return true;
    }
}

char BracketsTable(char bracket)
{
    switch (bracket)
    {
        case '(': return ')';
        case '{': return '}';
        case '[': return ']';
        default: return '_';
    }
}

string sequence = Console.ReadLine();
if (Brackets(sequence)) Console.WriteLine("Правильная последовательность");
else Console.WriteLine("Неправильная последовательность");