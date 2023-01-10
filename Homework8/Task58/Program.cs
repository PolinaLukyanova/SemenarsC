/* Задача 58. Задайте две матрицы.
 Напишите программу, которая будет находить произведение
  двух матриц. */


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

int[,] ReleaseMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
            result[i, j] = matrixA[i, j] * matrixB[i, j];
    }
    return result;
}



Console.Clear();
Console.Write($"Введите размер квадратной матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while(size[0] != size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер квадратной матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrixA = new int[size[0], size[1]];
int[,] matrixB = new int[size[0], size[1]];
InputMatrix(matrixA);
InputMatrix(matrixB);
Console.WriteLine("Массив 1: ");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Массив 2: ");
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Результат: ");
PrintMatrix(ReleaseMatrix(matrixA, matrixB));