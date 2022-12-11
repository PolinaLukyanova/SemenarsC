// задача 12. Напишите программа которая будет
// принимать два числа и выводить, является ли
// второ число кратным первому. Если число 2 
// не кратно числу 1, то программа выводит остаток от деления

Console.Clear();

Console.Write("Введите число1:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число2:");
int m = Convert.ToInt32(Console.ReadLine());

if (n % m == 0)
    Console.WriteLine($"Число {n} кратно {m} ");
else 
    Console.WriteLine($"Число {n} не кратно числу {m} и имеет остаток {n % m} ");
