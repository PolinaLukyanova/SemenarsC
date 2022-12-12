// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого 
// числа.

Console.Clear();

Console.Write("Введите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000)
{
    int n2 = (n % 100) / 10;
    Console.WriteLine($"{n2}");
}
else 
Console.WriteLine("Число не трехзначное");