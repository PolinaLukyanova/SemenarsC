﻿/*Задача 65. Задайте значения M и N. 
Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.

M = 1; N = 5 -> "1, 2, 3, 4, 5"

M = 4; N = 8 -> "4, 5, 6, 7, 8" . */

string rec(int m, int n)
{
    if (n == m)
        return $"{n} ";
    return rec(m, n - 1) + $"{n} ";
}


Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));