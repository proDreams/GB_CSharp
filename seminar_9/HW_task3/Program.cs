// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

bool Brackets(string seq)
{
    if (seq.Length % 2 != 0) return false;
    while (seq.Length > 0)
    {
        if (seq[1] == BracketsTable(seq[0])) seq = seq.Remove(0, 2);
        else if (seq[seq.Length - 1] == BracketsTable(seq[seq.Length - 2])) seq = seq.Remove(seq.Length - 2, 2);
        else if (seq[seq.Length - 1] == BracketsTable(seq[0]))
        {
            seq = seq.Remove(0, 1);
            seq = seq.Remove(seq.Length - 1, 1);
        }
        else break;
        // Console.WriteLine(seq); // Вывод для тестирования
    }
    if (seq.Length > 0) return false;
    else return true;
}

char BracketsTable(char bracket)
{
    switch (bracket)
    {
        case '(': return ')';
        case '{': return '}';
        case '[': return ']';
        case ')': return '(';
        case '}': return '{';
        case ']': return '[';
        default: return '_';
    }
}

string sequence = Console.ReadLine();
if (Brackets(sequence)) Console.WriteLine("Правильная последовательность");
else Console.WriteLine("Неправильная последовательность");