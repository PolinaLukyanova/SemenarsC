// array , Function

// Базовый шаблон для работы с массивами

Console.Clear();
Console.Write("Введите колличество элементов в массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); //[1, 10]

Console.WriteLine($"[{string.Join(", ", array)}]"); //функция string делает строку из массива. функция join указываем через что надо разделять эллементы массива