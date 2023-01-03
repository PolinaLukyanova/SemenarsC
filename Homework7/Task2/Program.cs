/* Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такой позиции в массиве нет (пользователь вводит нумерацию с 1)     */

void InputMatrix(int[,] matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine(); 
    }
 }


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);


Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == m - 1)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == n - 1)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                 
            }
        }
        else 
            
             Console.WriteLine("Вышли за предел маcсива");
             break;
    }