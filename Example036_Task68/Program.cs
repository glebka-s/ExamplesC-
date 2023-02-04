int GetIntPosNumberFromUser(string message, string ErrorMessage)
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

int Accerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if (m == 0)
            return(Accerman(n - 1, 1));
    return(Accerman(n - 1, Accerman (n, m - 1)));
}


int m = GetIntPosNumberFromUser("Введите m:", "Ошибка ввода!");
int n = GetIntPosNumberFromUser("Введите n:", "Ошибка ввода!");

Console.Write($"{Accerman(m, n)}");

