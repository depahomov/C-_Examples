/*
Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
Console.Write("Hello, ");
Console.Write(username);
*/

/*
 System.Console.WriteLine("Input number");
 int num = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine($"Your number -> {num} ");
*/

/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/

/*
System.Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int quad = num*num
System.Console.WriteLine($"q number -> {num*num} ");
System.Console.WriteLine("Input 3 digit number");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{   System.Console.WriteLine($"last number -> {num % 10} "); 
}
else
{
   System.Console.WriteLine("Not tree-digit number");
}
*/

/*
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"




/*
System.Console.WriteLine("Input number:");
int n = Convert.ToInt32(Console.ReadLine());
int count = -n;
while (count <=n ) 
     System.Console.Write(count++ + " ");
System.Console.WriteLine("Input number:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number:");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b)
{
    System.Console.WriteLine($"{a} is quad {b}");
}
else
{
    System.Console.WriteLine($"{a} is NOT quad {b}");
}
*/

/*
Урок 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Введите первое число (a): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (b): ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"Наибольшее число -> {a}");
}
else
{
    if (b > a)
    {
        Console.Write($"Наибольшее число -> {b}");
    }
    else
    {
        Console.Write($"Числа {a} и {b} равны");
    }
}
*/
//----------------------------------------------------------------------------------------------
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Введите первое число (a): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (b): ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"Наибольшее число -> {a}");
}
else
{
    if (b > a)
    {
        Console.Write($"Наибольшее число -> {b}");
    }
    else
    {
        Console.Write($"Числа {a} и {b} равны");
    }
}
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(a % 2);
//if (a % 2 )