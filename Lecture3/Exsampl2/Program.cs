// сортировка эллементов в массиве

//вводим массив
int[] arr = {1, 4, 6, 7, 8, 6, 5 };

//метод вывода массива на экран
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)  //проходим по массиву
    {
        Console.Write($"{array[i]} ");      //выводим на экран
    }
    Console.WriteLine();   //пустая страчка для удобства чтения
}

//метот который будет сортировать массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)  //проходим по всем эллементам массива
    {
        int minPosition = i;

        //ищем минимальный эллемент
        for (int j = i +1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);