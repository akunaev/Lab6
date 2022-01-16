// Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки.
// В строке может быть несколько фрагментов, заключённых в фигурные скобки.
// Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.

string S = Console.ReadLine();

int level = 0;

string S2 = "";

foreach (char c in S)
{
    switch (c)
    {
        case '{':
            level++;
            break;
        case '}':
            level--;
            if(level<0)
            {
                Console.WriteLine("Ошибка во входной строке!");
                return;
            }
            break;
        default:
            if (level == 0)
                S2 += c;
            break;
    }
}

Console.WriteLine(S2);
Console.ReadKey();