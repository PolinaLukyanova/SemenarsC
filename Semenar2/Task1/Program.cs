// Напишите программу, которая выводит случайное число из отрезка[10, 99] и показывает наибольшкю цифру числа.  Например: 78 > 8; 12 > 2; 85 > 8.

Console.Clear();

int n = new Random().Next(10, 100); // [begin, end +1] [10, 99]
Console.WriteLine($"Случайное число {n}");
int n1 = n / 10; // кол-во десятков
int n2 = n % 10; // кол-во едениц
if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);
    