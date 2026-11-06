// // string text = "Код 2026";
// // Console.WriteLine(text.Length);
// // Console.WriteLine(text[0]);
// // Console.WriteLine(text[text.Length - 1]);

// // int CountCharacter(string text, char target)
// // {
// //     int count = 0;
// //     foreach (char symbol in text)
// //     {
// //         if (symbol == target)
// //         {
// //             count++;
// //         }
// //     }
// //     return count;
// // }
// // Console.WriteLine(CountCharacter("мама", 'м'));
// // Console.WriteLine(CountCharacter("Код 2026", ' '));
// // Console.WriteLine(CountCharacter("", 'а'));


// int CountCharacter(string text, char target)
// {
//     int count = 0;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// // Console.WriteLine(CountCharacter("мама", 'м'));

// // int CountDigits(string text)
// // {
// //     int count = 0;
// //     foreach (char symbol in text)
// //     {
// //         if (char.IsDigit(symbol))
// //         {
// //             count++;
// //         }
// //     }
// //     return count;
// // }

// int CountLetters(string text)
// {
//     int count = 0;
//     foreach (char symbol in text)
//     {
//         if (char.IsLetter(symbol))
//         {
//             count++;
//         }
//     }
//     return count;
// }
// // Console.WriteLine(CountDigits("Код 2026!"));
// // Console.WriteLine(CountLetters("Код 2026!"));

// int CountDigits(string text)
// {
//     int count = 0;
//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count ++;
//         }
//     }
//     return count;
// }
// // Console.WriteLine(CountDigits("A2B3"));

// // int FindCharacterIndex(string text, char target)
// // {
// //     for (int i = 0; i < text.Length; i++)
// //     {
// //         if (text[i] == target)
// //         {
// //             return i;
// //         }
// //     }
// //     return -1;
// // }

// // Console.WriteLine(FindCharacterIndex("banana", 'a'));
// // Console.WriteLine(FindCharacterIndex("banana", 'b'));
// // Console.WriteLine(FindCharacterIndex("banana", 'z'));
// // Console.WriteLine(FindCharacterIndex("", 'a'));

// int FindCharacterIndex(string text, char target)
// {
//     int index = -1;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             index = i;
//             break;
//         }
//     }
//     return index;
// }
// // Console.WriteLine(FindCharacterIndex("banana", 'a'));

// // string sample = " кот ";
// // sample = sample.Trim();
// // Console.WriteLine($"[{sample}]");

// int CountWords(string text)
// {
//     string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     return words.Length;
// }

// // Console.WriteLine(CountWords("Я изучаю C#"));
// // Console.WriteLine(CountWords(" кот дом "));
// // Console.WriteLine(CountWords(""));
// // Console.WriteLine(CountWords(" "));

// // int CountWords(string text)
// // {
// //  string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// //  return words.Length;
// // }
// // Console.WriteLine(CountWords(" кот дом "));
// Console.Write("Введите строку: ");
// string text = Console.ReadLine() ?? "";

// System.Console.WriteLine(">>> Анализ строки <<<");
// System.Console.WriteLine($"Исходная строка:[{text}]");
// System.Console.WriteLine($"Длина: {text.Length}");
// System.Console.WriteLine($"Букв: {CountLetters(text)}");
// System.Console.WriteLine($"Цифр: {CountDigits(text)}");
// System.Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
// System.Console.WriteLine($"Слов: {CountWords(text)}");
// System.Console.WriteLine($"Без пробелов по краям:[{text.Trim()}]");
// System.Console.WriteLine($"Верхний регистр: [{ text.ToUpper()}]");
// System.Console.WriteLine($"Замена пробелов: [{text.Replace(' ', '_')}]");
// Console.Write("Введите один символ для поиска: ");
// char target = Convert.ToChar(Console.ReadLine()!);
// if (FindCharacterIndex(text, target) == -1)
// {
//     System.Console.WriteLine("Символ не найден");
// }
// else
// {
//     System.Console.WriteLine($"Первый индекс: {FindCharacterIndex(text, target)}");
// }


int FindLastCharacterIndex(string text, char target)
{
    int a = -1;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            a = i;
        }
    }
    return a;
}
System.Console.WriteLine("Введите слово");
string text = Console.ReadLine()!;
System.Console.WriteLine("Введить символ для поиска");
char targer = Convert.ToChar(Console.ReadLine()!);
System.Console.WriteLine(FindLastCharacterIndex(text, targer));