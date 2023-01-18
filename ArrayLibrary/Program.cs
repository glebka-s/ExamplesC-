int[] CreateIntArray(int N)
{
    int[] array = new int[N];
    int i = 0;
    while (i < N)
    {   
        int a;
        while (true)
        {   
            if (int.TryParse(Console.ReadLine(), out a))
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
    Console.Write(array[0]);
    int i = 1;
    while (i < len)
    {
        Console.Write($", {array[i]}");
        i++;
    }
}

void SelectionSortMinMax(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            } 
                
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortMaxMin(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            } 
                
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

int[] array = CreateIntArray(10);

PrintArray(array);