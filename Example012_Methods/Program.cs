// Вид1 void метод 
//Не принимает никаких аргументов и ничего не возвращает.

void Method1()
{
    Console.WriteLine("Автор Я");
}
//Method1();


//Вид2  void метод 
//Принимает какие-то аргументы, но ничего не возвращает.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Какой-то текст");


//часто бывает нужно, еслиметоды принимают какое-то количество аргументов, отличное от 1. 

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21 ("Text", 3);
//Делать вывод можно и так. Не обязательно в том порядке, в котором указано в объявлении аргументов в методе
//Method21 (count: 2, msg:"Text");



//Вид3 
//может что-то возвращать, но не принимает никаких аргументов. Например, может служить для генерации случайных данных.

int Method3()
{
    return DateTime.Now.Year;  //return - обязательный оператор
}
int Year = Method3();
//Console.WriteLine(Year);



// Вид4
// что-то принимает (аргументы, данные). И что-то возвращает для дальнейшей работы.
string Method4(int count, string text)
{
    //будем string компоновать друг за другом count раз
    int i = 0;
    string result = String.Empty; //Пустая строка

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Zz");
Console.WriteLine(res);