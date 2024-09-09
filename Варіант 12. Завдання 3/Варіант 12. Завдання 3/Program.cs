
string s = "apple banana avocado"; // оголошуємо змінну з рядком
string[] words = s.Split(" "); // розбиваємо рядок на слова

// проходимо по кожному слову в реченні за допомогою циклу for
for (int i = 0; i < words.Length; i++)
{
    string word = words[i]; // беремо поточне слово

    // перевіряємо, чи слово не порожнє
    if (word.Length > 0)
    {
        char firstLetter = word[0]; // беремо першу букву слова
        
        int count = 0; // рахуємо кількість входжень першої букви в слові

        for (int j = 0; j < word.Length; j++)
        {
            if (word[j] == firstLetter)
            {
                count++; // збільшуємо лічильник, якщо буква співпадає з першою
            }
        }

        // якщо перша буква зустрічається більше одного разу, виводимо слово
        if (count > 1)
        {
            Console.WriteLine(word);
        }
    }
}

Console.ReadKey();