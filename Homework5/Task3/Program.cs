﻿/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76   */

void InputArray(double[] array)
 {
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() *(30-1) + 1, 2);
 }

object? ReleaseArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
            max = array[i];
        else if (array[i] <= min)
            min = array[i];
    }
    result = max - min;
    return result;
   
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join("; ", array)}]");

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {ReleaseArray(array) }");
