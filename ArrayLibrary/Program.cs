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

int[] CreateRandomArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int[,] CreateMatrix(int n, int m)
{   
    int[,] result = new int[n ,m];
    int a;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            while (true)
            {   
                if (int.TryParse(Console.ReadLine() ?? "", out a))
                    break;
                Console.WriteLine("Ошибка ввода!");
            }
            result[i, j] = a;
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4,4);
PrintMatrix(matrix);