
string s = "АУАУАПАУК";
int i = 0;

do
{
    string ss = s.Substring(i, 2);

    if (ss == "АУ")
    {
        s = s.Insert(i, "О");
        i = i + 3;
    }
    else
    {
        i++;
    }
}

while (i < s.Length - 1); 

Console.WriteLine(s);
Console.ReadKey();