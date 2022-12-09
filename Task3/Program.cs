Console.Clear();

Console.Write("Введите число1:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2:");
int m = Convert.ToInt32(Console.ReadLine());

if (m * m == n)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
    