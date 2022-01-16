//Ввести с клавиатуры предложение.
//Предложение представляет собой слова, разделенные пробелом.
//Знаки препинания не используются. Найти самое длинное слово в строке.

string str = Console.ReadLine();
string[] strArray = str.Split();

int max = 0;
string maxStr = "";
foreach (string str2 in strArray)
{
    if (str2.Length > max)
    {
        max = str2.Length;
        maxStr = str2;
    }
}

Console.WriteLine(maxStr);