//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”


string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

 // string s = “qwerty”
// 012345
// s[3] // r

string Replase(string text, char oldValue, char NewValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i]==oldValue) result = result + $"{NewValue}";
        else result = result+ $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ' ,'|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'с', 'С');
Console.WriteLine(newText);