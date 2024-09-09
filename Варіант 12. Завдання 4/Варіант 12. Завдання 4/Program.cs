
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
        char firstLetter = char.ToUpper(word[0]); // робимо першу букву великою

        // перевертаємо слово
        string reversedWord = "";
        for (int j = word.Length - 1; j >= 0; j--)
        {
            reversedWord += word[j];
        }

        // додаємо перевернуте слово до нового речення
        newS += reversedWord + " ";
    }
}

// виводимо нове речення, видалаючі пробіли в кінці
Console.WriteLine(newS.Trim());
Console.ReadKey(); 