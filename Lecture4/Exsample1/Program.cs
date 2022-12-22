// двумерные массивы

string[,] table = new string [2,5];
// String.Empty
// table [0, 0]     table [0, 1]    table [0, 2]...  table [0, 4]
// table [1, 0]     table [1, 1]    table [1, 2]...  table [1, 4]


table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++) // rows - строки
{
    for (int columns = 0; columns < 5; columns++) // columns - колонки(столбцы)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}





int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++) // внешний цикл переключающий строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) //внутрений цикл переключающий столбцы
    {
       Console.Write($"{matrix[i, j]} "); 
    }
Console.WriteLine();
}