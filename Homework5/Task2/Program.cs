using static System.Console;

Clear();

int[] arr = GetArray();
PrintArray(arr);
int result = SummOdd(arr);
WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {result}");

int[] GetArray()
{
    int[] array = new int[4];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
}

int SummOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        sum += i % 2 != 0 ? array[i] : 0;
    }
    return sum;
}