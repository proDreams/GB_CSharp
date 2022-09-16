// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

bool Brackets(string seq)
{
    int changes = 1;
    if (seq.Length % 2 != 0) return false;
    while (changes > 0)
    {
        changes = 0;
        for (int i = 0; i < seq.Length; i++)
        {
            if (i + 1 > seq.Length - 1) break;

            string temp = seq[i].ToString() + seq[i + 1].ToString(); // без ToString почему то говорит, что нельзя преобразовать int в string
            if (BracketsTable(temp))
            {
                seq = seq.Remove(i, 2);
                changes++;
            }
        }
    }
    if (seq.Length > 0) return false;
    else return true;
}

bool BracketsTable(string bracket)
{
    switch (bracket)
    {
        case "()": return true;
        case "{}": return true;
        case "[]": return true;
        default: return false;
    }
}

string sequence = Console.ReadLine() ?? string.Empty;
if (Brackets(sequence)) Console.WriteLine("Правильная последовательность");
else Console.WriteLine("Неправильная последовательность");