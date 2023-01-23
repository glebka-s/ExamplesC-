// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

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

double GetDoubleNumberFromUser(string ErrorMessage)
{
    while(true)
    {
        if (double.TryParse(Console.ReadLine(), out double UserNumber))
            return UserNumber;
        Console.WriteLine(ErrorMessage);
    }
}

int N = GetIntPosNumberFromUser("Введите количество чисел:", "Ошибка ввода!");

int count = 0;

Console.WriteLine("Вводите числа:");
for(int i = 0; i < N; i++)
{
    double number = GetDoubleNumberFromUser("Ошибка ввода!");
    if (number > 0)
        count += 1;
}
Console.Write($"Количество положительных чисел  = {count}");