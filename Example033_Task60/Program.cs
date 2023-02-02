// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

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

int[,,] CreateArray(int n, int m, int k)
{   
    int[,,] result = new int[n ,m, k];
    int a;
    for (int l = 0; l < k; l++)
    {
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
                result[i, j, l] = a;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] matrix)
{
    for (int l = 0; l < matrix.GetLength(2); l++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j,l]}({i},{j},{l}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Будем рассматривать массив размерами n x m x k");
int n = GetIntPosNumberFromUser("Введите n", "Ошибка ввода!");
int m = GetIntPosNumberFromUser("Введите m", "Ошибка ввода!");
int k = GetIntPosNumberFromUser("Введите k", "Ошибка ввода!");

int[,,] array = CreateArray(n, m, k);

PrintArray(array);




