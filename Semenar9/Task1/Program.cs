// нахождение суммы чисел с помощью рекурсии

int sum(int a, int b)
{
    if (b == 0)
        return a;
    return sum(a + 1, b - 1);
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(n, m));