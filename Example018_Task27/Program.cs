// Принимает на вход число и выдаёт сумму цифр в числе.

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

int GetSumOfNumbers(int N)
{
    int result = 0, M = N;
    while (M != 0)
    {
        result += Math.Abs(M % 10);
        M /= 10;
    }
    return result;
}

int N = GetIntNumberFromUser("Введите целое число:", "Ошибка ввода!");
Console.Write($"{N} -> {GetSumOfNumbers(N)}");