int GetIntNumberFromUser(string message, string ErrorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
            return UserNumber;
        Console.WriteLine(ErrorMessage);
    }
}

int summ(int M, int N)
{
    if (M == N)
        return N;
    return M + summ(M + 1, N);
}

int M = GetIntNumberFromUser("Введите M:", "Ошибка ввода!");
int N = GetIntNumberFromUser("Введите N:", "Ошибка ввода!");

Console.Write($"Сумма = {summ(M, N)}");
