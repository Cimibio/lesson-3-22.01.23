// сортировка массива
int[] array = new int[10];
for (int i = 0; i <= 9; i = i++)
{
    array[i] = new Random().Next(0,10);
}
void PrintArray(int[] arg)
{
    int count = arg.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array);

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i +1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPos]) minPos = j;
        }

        int temp = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temp;
    }
}
SelectionSort(array);
PrintArray(array);