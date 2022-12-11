// поиск позиции нужного эллемента
int[] array = { 1, 2, 8, 4, 5, 6, 7, 8 };

int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;   //прерви
    }
    // index = index +1;
    index++;
}


// можно сделать лучше