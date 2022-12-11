void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray( int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; // 1. определили массив из 10 эллементов

FillArray(array); // 2. вызвали метод FillArray который заполнил наш массив
PrintArray(array); //3. метот PrintArray вывел наш массив на экран

