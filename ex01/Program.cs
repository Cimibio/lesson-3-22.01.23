// See https://aka.ms/new-console-template for more information
string text = " много букав" + "ещё один текст" + "и дополнитедбная пачка текста" + "бонусный текст с бонусом";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
