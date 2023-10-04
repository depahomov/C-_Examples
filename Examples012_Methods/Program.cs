//Методы

//Вид 1
void Method1()
{
    Console.WriteLine("Автор Пахомов Дмитрий");
}

Method1();
System.Console.WriteLine();

//Вид 2
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Текст сообщения");
System.Console.WriteLine();

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
    System.Console.WriteLine(msg);
}
Method21(count: 4, msg: "Текст сообщения 2");
System.Console.WriteLine();
System.Console.WriteLine();


//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
System.Console.WriteLine();


//Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "ZV_");
System.Console.WriteLine(res);
System.Console.WriteLine();

