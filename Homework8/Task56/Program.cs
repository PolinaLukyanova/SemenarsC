/* Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с 
 наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
    } 
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    } 
}

int ReleaseMatrix(int[,] matrix)
{
    int  minLine = 0; 
    
    for (int i = 0; i < matrix.GetLength(1); i++)
        minLine += matrix[0, i]; //сумма первой строки
            
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumLine = 0;
            for   (int j = 0; j < matrix.GetLength(1); j++)
            {
                sumLine += matrix[i, j];// сумма последующих строк и
            }
            if (minLine > sumLine) // сравнивание строк
                minLine = sumLine;
            
        }
    return minLine;
    }   

Console.Clear();
Console.Write($"Введите размер прямоугольной матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while(size[0] == size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер прямоугольной матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Результат: {ReleaseMatrix(matrix)}");





// Пыталась написать программу которая будет выводить НОМЕР строки с наименьшим значением 


// int temp = 0, minSumLine = 0, sumLine = 0, row = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     sumLine = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sumLine += matrix[i, j]; //сумма элементов первой строки
        
//     }
//     if (sumLine < minSumLine)
//     { 
//         temp = sumLine;  
//         row = i;
//         minSumLine = sumLine;
//     }
//     Console.WriteLine($"Наименьшаяя сумма = {temp}");
//     Console.WriteLine($"Номер строки: {row}");
//     // Console.WriteLine();
//     // Console.WriteLine($"Сумма {(i+1)} строки равна {sumLine}");
// }



 