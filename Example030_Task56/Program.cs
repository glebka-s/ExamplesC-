// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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



int n = GetIntPosNumberFromUser("Введите количество строк:", "Ошибка ввода!");
int m = GetIntPosNumberFromUser("Введите количество столбцов:", "Ошибка ввода!");
int[,] matrix = CreateMatrix(n ,m);
PrintMatrix(matrix);

int sum = 0;

for (int j = 0; j < m; j++)
{
    sum += matrix[0, j];
}

int MinSum = sum;
int index = 0;

for (int i = 1; i < n; i++)
{
    sum = 0;
    for (int j = 0; j < m; j++)
    {
        sum += matrix[i, j];
    }
   if (sum < MinSum)
   {
    MinSum = sum;
    index = i; 
   }
}

Console.Write(index + 1);