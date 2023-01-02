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
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int k = Convert.ToInt32(Console.ReadLine());
int[] result = new int[numbers.Length];
k %= n;
if (k > 0)
{
for (int i = 0; i < k; i++)
result[i] = numbers[numbers.Length - k + i];
for (int i = 0; i < numbers.Length - k; i++)
result[k + i] = numbers[i];
Console.WriteLine($"{string.Join(" ", result)}");
}
else
{
k = k * (-1);
for (int i = 0; i < k; i++)
result[numbers.Length - k + i] = numbers[i];
for (int i = 0; i < numbers.Length - k; i++)
result[i] = numbers[k + i];
Console.WriteLine($"{string.Join(" ", result)}");
}