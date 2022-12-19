/* Суперсдвиг
(Время: 1 сек. Память: 16 Мб Сложность: 20%)
Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).
Выходные данные
В выходной файл OUTPUT.TXT выведите полученную последовательность.
5
5 3 7 4 6       ->        7 4 6 5 3
3	    

5                        
5 3 7 4 6       ->         4 6 5 3 7
-3      */

Console.Clear();
Console.Write("Введите колличество элементов в массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; 

for ( int i = 0; i < n; i++)
{
Console.Write($"Введите {i + 1}-й элемент массива: ");
array[i] = Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine($"[{string.Join(", ", array)}]");

// Console.Write("Введите число на которое надо сделать сдвиг: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int tmp = array[n - 1];

// for (int i = n -1; i > 0; i--)
// {
//     array[i] = array[i - 1];
//     array[0] = tmp;


    // for (int j = 0; j < n-1; j++)
    // {
    //     array[j] = array[j + 1];
    //     array[j + 1] = tmp;
    // }
// }

Console.WriteLine($"[{string.Join(", ", array)}]");
