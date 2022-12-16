// Array
// Double numbers - дробные числа

Console.Clear();
Console.Write("Введите колличество элементов в массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    //         округляет до заданного значения |    * (end - begin) + begin
    array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); 
}
Console.WriteLine($"[{string.Join(", ", array)}]"); //функция string делает строку из массива. функция join указываем через что надо разделять эллементы массива