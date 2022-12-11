// Задача 16. Напишите программу, которая принимает
// на вход два числа и проверяет, является ли
// одно число квадратом другого.

Console.Clear();

Console.Write("Введите число1:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2:");
int m = Convert.ToInt32(Console.ReadLine());

if (n * n == m)
    Console.WriteLine("yes");
else if (m * m == n)
    Console.WriteLine("yes");
else 
    Console.WriteLine("no");