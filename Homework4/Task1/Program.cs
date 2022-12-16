/* Задача 25: Напишите цикл, который принимает на 
вход два числа (A и B) и возводит число A в натуральную 
степень B.
Нельзя использовать функцию Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.Clear();
Console.Write("Введите 1-е число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= m; i++)
{

    result *= n;

}

Console.WriteLine(result);