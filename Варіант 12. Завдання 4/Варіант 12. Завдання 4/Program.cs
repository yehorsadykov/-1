
string s = "мама миє посуд"; // оголошуємо рядок з реченням
string[] words = s.Split(' '); // розбиваємо речення на слова
string newS = ""; // оголошуємо змінну для зберігання нового речення

// проходимо по кожному слову через цикл for
for (int i = 0; i < words.Length; i++)
{
    // якщо номер слова непарний (i + 1, бо індекси починаються з 0)
    if ((i + 1) % 2 != 0)
    {
        string word = words[i]; // беремо слово та виводимо його у зворотному порядку
        string reversedWord = ""; // перевертаємо слово

        for (int j = word.Length - 1; j >= 0; j--)
        {
            reversedWord += word[j];
        }

        char firstLetter = char.ToUpper(reversedWord[0]); // перша буква буде велика
        string formattedWord = firstLetter + reversedWord.Substring(1).ToLower(); // останні букви будуть з малої літери
        newS += formattedWord + " "; // додаємо перевернуте слово до нового речення
    }
}

Console.WriteLine(newS.Trim()); // виводимо нове речення, видалаючі пробіли в кінці
Console.ReadKey(); 