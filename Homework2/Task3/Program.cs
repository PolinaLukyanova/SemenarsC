// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите число от 1 до 7:");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 5)
{
    Console.WriteLine($"yes");
}
else 
 Console.WriteLine($"no");