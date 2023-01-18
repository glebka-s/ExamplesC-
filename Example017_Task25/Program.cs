// Принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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

int Pow(int number, int degree)
{
    int result = 1; 
    for (int i = 1; i <= degree; i++)
    {
        result *= number;
    }
    return result;
}

int A = GetIntNumberFromUser("Введите число:", "Ошибка ввода!");
int B = GetIntNumberFromUser("Введите натуральный показатель степени:", "Ошибка ввода!");

Console.Write($"{A}, {B} -> {Pow(A,B)}");