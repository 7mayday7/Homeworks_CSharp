using static System.Console;

Clear();

GetArray();

int[] GetArray()
{
    Write("[");
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = random.Next(1, 100);
        Write($"{array[i]}, ");
    }

    WriteLine($"{array[array.Length - 1] = random.Next(1, 100)}]");
    return array;
}