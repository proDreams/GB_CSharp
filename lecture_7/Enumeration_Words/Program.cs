// без рекурсии
// char[] s = { 'а', 'и', 'с', 'в'};

// int count = s.Length;

// int n = 1;

// for (int i = 0; i < count; i++) // Перебор однобуквеннных слов
// {
//     for (int j = 0; j < count; j++) // Перебор двубуквенных слов
//     {
//         for (int k = 0; k < count; k++) // Перебор трёхбуквенных слов
//         {
//             for (int l = 0; l < count; l++) // Перебор четырёхбуквенных слов
//             {
//                 for (int m = 0; m < count; m++) // Перебор пятибуквенных слов
//                 {
//                     Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                 }
//             }
//         }
//     }
// }

// с рекурсией
int n = 1;

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[5]);