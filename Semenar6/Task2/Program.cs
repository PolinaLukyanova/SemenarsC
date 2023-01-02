/* Задача 40. Напишите программу, которая принимает на вход 
три числа и проверяет, может ли существовать трекгольник со 
сторонами такой длины. 
Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон.    */


Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Треугольник");
else 
    Console.WriteLine("Нет");
