// Напишите программу, которая будет находить произведение двух матриц.

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



int n1 = GetIntPosNumberFromUser("Введите количество строк первой матрицы:", "Ошибка ввода!");
int m1 = GetIntPosNumberFromUser("Введите количество столбцов первой матрицы:", "Ошибка ввода!");
int n2 = GetIntPosNumberFromUser("Введите количество строк первой матрицы:", "Ошибка ввода!");
int m2 = GetIntPosNumberFromUser("Введите количество столбцов первой матрицы:", "Ошибка ввода!");

if (m1 != n2)
{
    Console.Write("Матрицы невозможно перемножить!");
}
else{
    Console.WriteLine("Элементы первой матрицы:");
    int[,] matrix1 = CreateMatrix(n1, m1);
    Console.WriteLine("Элементы второй матрицы:");
    int[,] matrix2 = CreateMatrix(n2, m2);
    Console.WriteLine("Первая матрица:");
    PrintMatrix(matrix1);
    Console.WriteLine("Вторая матрица:");
    PrintMatrix(matrix2);
    int[,] matrix1Xmatrix2 = new int[n1, m2];
    
    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < m2; j++)
        {
            for (int k = 0; k < m1; k++)
            {
                matrix1Xmatrix2[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    Console.WriteLine("Произведение матриц:");
    PrintMatrix(matrix1Xmatrix2);
}
