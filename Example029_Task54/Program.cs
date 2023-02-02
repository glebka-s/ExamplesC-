// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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



int n = 3, m = 4;
int[,] matrix = CreateMatrix(n, m);
PrintMatrix(matrix);

for (int i = 0; i < n; i++)
{
    int [] array = new int[m];
    for (int j = 0; j < m; j++){
        array[j] = matrix[i,j];
    }

    SelectionSortMaxMin(array);
    
    for (int j = 0; j < m; j++){
        matrix[i,j] = array[j];
    }
}

Console.WriteLine("Упорядоченная матрица:");
PrintMatrix(matrix);
