// задача 14. Напишите программу , которая принимает 
// на ввод число и проверяет , кратно ли оно 
// одновременно 7 и 23

Console.Clear();

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

if ( n % 7 == 0 )
{
    if (n % 23 == 0)
    Console.WriteLine($"Число {n} кратно 7 и 23");
    else 
    Console.WriteLine($"Число {n} не кратно 7 и 23");
}

else 
    Console.WriteLine($"Число {n} не кратно 7 и 23");