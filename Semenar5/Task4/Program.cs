﻿/* Задача 35: Задайте одномерный массив из 123 случайных 
чисел. Найдите количество элементов массива, значения 
которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 .    */

void InputArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101); //[-100, 100]
 } 

int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
             count = 1 + count;
    }
    return count;
}

Console.Clear();

int[] array = new int[123];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(ReleaseArray(array));
