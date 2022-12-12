// задача 17. напишите программу, которая принимает 
// на вход координаты точки(X и Y), причем X не= 0 и 
// Y не=0 и выдает номер четверти плоскости, в которой 
// находится эта точка.

Console.Clear();
Console.Write("Введите координату Х: ");
double x =Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y: ");
double y =Convert.ToDouble(Console.ReadLine());

while (x == 0)
{
    Console.Write("Вы ошоблись!\nВведите координату Х: ");
    x =Convert.ToDouble(Console.ReadLine());
}

while (y == 0)
{
    Console.Write("Вы ошоблись!\nВведите координату Y: ");
    y =Convert.ToDouble(Console.ReadLine());
}

if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else 
    Console.WriteLine("IV");

