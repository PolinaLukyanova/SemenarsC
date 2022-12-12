// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 1000)
{
    n = n / 10;
}

if (n >= 100 && n < 1000)
{
    int n1 = n % 100;
    int n2 = n / 10;
    int n3 = n % 10;
    Console.WriteLine($"{n3}");
}


else 
Console.WriteLine("Третьей цифры нет");