//Ввести с клвиатуры предложение.
//Предложение представляет собой слова, разделенные пробелом.
//Знаки препинания не используются.
//Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»)

string str = Console.ReadLine();
string strWithoutSpaces = "";

string[] strArray = str.Split();

foreach (string str2 in strArray)
{
    strWithoutSpaces += str2;
}

strWithoutSpaces = strWithoutSpaces.ToLower();

bool flag = true;
for (int i = 0; i < strWithoutSpaces.Length/2; i++)
{
    if(strWithoutSpaces[i] != strWithoutSpaces[strWithoutSpaces.Length-1-i])
    { flag= false; break; }
}

if (flag)
{
    Console.WriteLine("Фраза является палиндромом");
}
else
{
    Console.WriteLine("Фраза не является палиндромом");
}

Console.ReadKey();
