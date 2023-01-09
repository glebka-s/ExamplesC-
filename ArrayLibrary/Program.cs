int[] CreateArray(int N)
{
    int[] array = new int[N];
    int i = 0;
    while (i < N)
    {
        int a = int.Parse(Console.ReadLine() ?? "");
        array[i] = a;
        i++;
    }
    return(array);
}

void PrintArray(int[] array)
{
    int len = array.Length;
    Console.Write(array[0]);
    int i = 1;
    while (i < len)
    {
        Console.Write($", {array[i]}");
        i++;
    }
}

int[] array = CreateArray(10);
PrintArray(array);