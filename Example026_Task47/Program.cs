// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int GetIntPosNumberFromUser(string message, string ErrorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
        {
            if (UserNumber > 0)
                return UserNumber;
        }
        Console.WriteLine(ErrorMessage);
    }
}

double[,] CreateRandomMatrix(int n, int m)
{   
    double[,] result = new double[n ,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().NextDouble();
        }
    }
    return result;
}

void PrintMatrix(double[,] matrix)
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

int n = GetIntPosNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int m = GetIntPosNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
double[,] matrix = CreateRandomMatrix(n, m);
PrintMatrix(matrix);