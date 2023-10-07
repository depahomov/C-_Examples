
/*
string[,] table = new string[2, 5];
//table[1, 2] = "слово";
// table[0, 0]  table[0, 1] table[0, 2] ... table[0, 4]
// table[1, 0]  table[1, 1] table[1, 2] ... table[1, 4]
// ...
// table[4, 0]  table[4, 1] table[4, 2] ... table[4, 4]

for (int rows = 0; rows < 5; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        System.Console.WriteLine($"-{table[rows, colums]}-");
    }
}
*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //от 1 до 9
        }
    }
}
System.Console.WriteLine("Инициализация массива и вывод на экран:");
int[,] matix = new int[3, 4];
PrintArray(matix);
System.Console.WriteLine();

System.Console.WriteLine("Заполнение массива случайными числами от 1 до 9 и вывод на экран:");
FillArray(matix);
PrintArray(matix);