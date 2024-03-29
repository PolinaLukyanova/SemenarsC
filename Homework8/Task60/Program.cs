﻿/* Задача 60. ...Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. Напишите 
программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void InputMatrix(int[,,] matrix)
{
    int numbers = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            matrix[i, j, k] = numbers++;
            
        }
    } 
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})");
            
        Console.WriteLine();
        }
    } 
}


Console.Clear();
Console.Write($"Введите размер : ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while ( size[0] * size[1] * size[2] > 90)
{
    Console.Write($"Вы ошиблись! \n  Введите размер: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);
PrintMatrix(matrix);
