// Задаёт массив из 8 элементов и выводит их на экран.
int[] CreateIntArray(int N)
{
    int[] array = new int[N];
    int i = 0;
    while (i < N)
    {   
        int a;
        while (true)
        {   
            if (int.TryParse(Console.ReadLine() ?? "", out a))
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        array[i] = a;
        i++;
    }
    return(array);
}

void PrintArray(int[] array)
{
    int len = array.Length;
    Console.Write($"[{array[0]}");
    int i = 1;
    while (i < len)
    {
        Console.Write($", {array[i]}");
        i++;
    }
    Console.Write("]");
}

int[] array = CreateIntArray(8);
PrintArray(array);