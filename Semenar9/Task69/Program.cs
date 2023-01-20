/* Задача 69. Напишите программу,
 которая на вход принимает два числа A и B, 
 и возводит число А в целую степень B с помощью 
 рекурсии. */
int rec(int a, int b)
{
    if (b == 0)
        return 1;
    return rec(a, b - 1) * a ;
}



Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(a, b));
