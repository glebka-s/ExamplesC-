// Напишите программу, которая заполнит спирально массив 4 на 4 (сделал для произвольного массива).

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



int n = GetIntPosNumberFromUser("Введите количество строк матрицы:", "Ошибка ввода!");
int m = GetIntPosNumberFromUser("Введите количество столбцов матрицы:", "Ошибка ввода!");

int[,] matrix = new int[n,m];

int index1 = 0, index2 = 0;
int direction = 1; // введём указатель направления: 1-вправо, 2-вниз, 3-влево, 4-вверх
matrix[0,0] = 1;
for (int i = 1; i < m * n; i++)
{
    if (direction == 1)
    {
        while (true)
        {
            if ( (index2 + 1 == m) || (matrix[index1, index2 + 1] != 0) )
            {
                direction = 2;
                break;
            }

            matrix[index1, index2 + 1] = matrix[index1, index2] + 1;
            index2 += 1;
        }
    }

    if (direction == 2)
    {
        while (true)
        {
            if ( (index1 + 1 == n) || (matrix[index1 + 1, index2] != 0) )
            {
                direction = 3;
                break;
            }

            matrix[index1 + 1, index2] = matrix[index1, index2] + 1;
            index1 += 1;
        }
    }

    if (direction == 3)
    {
        while (true)
        {
            if ( (index2 == 0) || (matrix[index1, index2 - 1] != 0) )
            {
                direction = 4;
                break;
            }

            matrix[index1, index2 - 1] = matrix[index1, index2] + 1;
            index2 -= 1;
        }
    }

    if (direction == 4)
    {
        while (true)
        {
            if ( (index1 == 0) || (matrix[index1 - 1, index2] != 0) )
            {
                direction = 1;
                break;
            }

            matrix[index1 - 1, index2] = matrix[index1, index2] + 1;
            index1 -= 1;
        }
    }

}

PrintMatrix(matrix);

