// table[0, 0]  table[0, 1] table[0, 2] ... table[0, 4]
// table[1, 0]  table[1, 1] table[1, 2] ... table[1, 4]
// ...
// table[4, 0]  table[4, 1] table[4, 2] ... table[4, 4]
/*
string[,] table = new string[2, 5];
//table[1, 2] = "слово";

for (int rows = 0; rows < 5; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        System.Console.WriteLine($"-{table[rows, colums]}-");
    }
}
*/

int[,] matrix = new int[3, 4];



for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; i < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}