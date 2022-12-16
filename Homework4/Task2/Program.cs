/* Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int n1 = 0;

while (n > 0)
{
    n1 = n % 10;
    sum = sum + n1;
    n = n / 10;
}

Console.WriteLine(sum);