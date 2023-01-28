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