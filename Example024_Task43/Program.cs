// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double GetDoubleNumberFromUser(string message, string ErrorMessage)
{
    while(true)
    {   
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out double UserNumber))
            return UserNumber;
        Console.WriteLine(ErrorMessage);
    }
}

Console.WriteLine("Прямые задаются уравнением вида y = k1 * x + b1");

double k1 = GetDoubleNumberFromUser("Введите k1:", "Ошибка ввода!");
double b1 = GetDoubleNumberFromUser("Введите b1:", "Ошибка ввода!");
double k2 = GetDoubleNumberFromUser("Введите k2:", "Ошибка ввода!");
double b2 = GetDoubleNumberFromUser("Введите b2:", "Ошибка ввода!");

double x = (b2 - b1) / (k1 - k2);
Console.Write($"({x};{k1 * x + b1})");