
string s = "hello world, welcome to the Moon!";
string s1 = "Moon"; // рядок, який будемо замінювати
string s2 = "Earth"; // рядок, на який будемо замінювати
int lastIndex = s.LastIndexOf(s1); // знаходимо індекс останнього входження рядка s1

if (lastIndex != -1) // перевіряємо, чи рядок s1 присутній у s
{
    // розбиваємо рядок на частини та замінюємо останнє входження s1 на s2
    s = s.Remove(lastIndex, s1.Length).Insert(lastIndex, s2);
}

Console.WriteLine(s); // виводимо результат на екран
Console.ReadKey();