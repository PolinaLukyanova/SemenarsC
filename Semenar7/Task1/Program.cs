/*   Задача 46. Задайте двумерный массив размером m*n,
 заполненый случайными целыми числами */

 //метод на заполнение массива случайными числами
 void InputMatrix(int[,] matrix)
 {
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine(); //переход на новую строку для красоты и просототы чтения
    }
 }


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);