/* Задача 24. Напишите программу, которая принимает
на вход число(А) и выдает сумму чисел от 1 до А.
Сумма арифметической прогрессии.

7 -> 28
4 -> 10
8 -> 36
 */

Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((1 + n) / 2 * n);
