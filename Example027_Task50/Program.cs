/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int GetIntNumberFromUser(string message, string ErrorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
        {
            if (UserNumber >= 0)
                return UserNumber;
        }
        Console.WriteLine(ErrorMessage);
    }
}

int[,] CreateRandomMatrix(int n, int m)
{   
    int[,] result = new int[n ,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(-9,10);
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

void SearchMatrixElement(int[,] matrix, int n,int m)
{
    if (n > matrix.GetLength(0) - 1 || m > matrix.GetLength(1) - 1)
        Console.WriteLine("Такого элемента нет!");
    else
        Console.WriteLine($"{n}, {m} -> {matrix[n ,m]}");
}



int[,] matrix = CreateRandomMatrix(4, 4);
PrintMatrix(matrix);

int n = GetIntNumberFromUser("Введите индекс строки:", "Ошибка ввода!");
int m = GetIntNumberFromUser("Введите индекс столбца:", "Ошибка ввода!");
SearchMatrixElement(matrix, n, m);

