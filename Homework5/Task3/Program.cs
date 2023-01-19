using static System.Console;

Clear();

double[] arr = GetArray();
PrintArray(arr);
WriteLine("\nРазница между макс и мин: {0:F2}", diffMaxMin(arr));

double[] GetArray()
{
    double[] array = new double[4];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write("{0:F2}   ", array[i]);
    }
}

double diffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }

    double diff = max - min;

    return diff;
}