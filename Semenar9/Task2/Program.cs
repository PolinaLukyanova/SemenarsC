﻿/* Сумма последовательности
Дана последовательность чисел, завершающаяся числом 0. Найдите сумму всех этих чисел , не используя цикл.
Вводится последовательность целых чисел, окончивающаяся числом 0(само число0 в последовательность не входит, а служит как признак ее окончания)*/


int sum()
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
        return 0;
    return sum() + x;
}


Console.Clear();
Console.WriteLine(sum());

