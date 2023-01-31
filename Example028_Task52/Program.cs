// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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


int[,] matrix = CreateMatrix(4, 4);
double sum = 0;
PrintMatrix(matrix);
for(int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += (double)matrix[i, j];
    }
    Console.Write($"{sum / matrix.GetLength(0)}  ");
    sum = 0;
}

