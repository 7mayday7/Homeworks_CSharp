using static System.Console;

Clear();

int[] arr = GetArray();
PrintArray(arr);
int even = CountEvenNum(arr);
WriteLine($"\nКоличество четных чисел: {even}");

int[] GetArray()
{
    int[] array = new int[4];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
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

int CountEvenNum(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        count += el % 2 == 0 ? 1 : 0;
    }
    return count;
}