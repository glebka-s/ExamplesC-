// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

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

void Numbers(int M, int N)
{   
    if (M < N)
        Numbers(M + 1, N);
    Console.Write($"{M} ");
}

Numbers(1, GetIntPosNumberFromUser("Введите N:", "Ошибка ввода!"));