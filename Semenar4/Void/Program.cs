// Void

void test(ref int a)
{
a += 5;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
test(ref n);
Console.WriteLine(n);