/* Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int akk(int m, int n)
{
    if (m == 0 )
    return n + 1;
    else if (m == 1)
    return n + 2;
    else if (m == 2)
    return 2*n +3;
    else 
    return (1 << (n + 3)) - 3;
}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = {akk(m, n)}");