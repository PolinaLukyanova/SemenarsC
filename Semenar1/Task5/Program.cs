﻿// Console.Write("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = (-1) * n; i <= n; i++)
//     Console.Write($"{i} ");



Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = (-1) * n;
while (i <= n)
{
    Console.Write($"{i} ");
    i++;
}
