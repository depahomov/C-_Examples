//Методы

//Вид 1 (ничего не принимает, ничего не передаёт)
/*
void Method1()
{
    Console.WriteLine("Автор Пахомов Дмитрий");
}

Method1();
System.Console.WriteLine();

//Вид 2 (что-то принимает, ничего не передаёт)
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

Method2("Текст сообщения");
System.Console.WriteLine();
*/


// метод с несколькими параметрами
/*
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
*/

//Вид 3  (ничего не принимает, что-то передаёт)
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
System.Console.WriteLine();
*/

//Вид 4 (что-то принимает, что-то передаёт)
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "ZV_");
System.Console.WriteLine(res);
System.Console.WriteLine();
*/

// ======== Работа с текстом==========
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3] - это r

/*
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
System.Console.WriteLine(text);

string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'у', 'У');
System.Console.WriteLine(newText);
*/

//Сортировка массива методом выбора

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();

}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

