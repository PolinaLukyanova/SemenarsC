// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Введите число1:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} -max  {b} -min");
}
else if (a == b)
{
    Console.WriteLine($"числа равны");
}
else if (a < b)
{
    Console.WriteLine($" {b} -max {a} -min");
}