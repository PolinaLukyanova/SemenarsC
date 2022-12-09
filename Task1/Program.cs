Console.Clear();

Console.Write("Введите год:");

int n = Convert.ToInt32(Console.ReadLine());

if (n % 400 == 0 || n % 100 != 0 && n % 4 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");