﻿int GetIntNumberFromUser(string message, string ErrorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber))
            return UserNumber;
        Console.WriteLine(ErrorMessage);
    }
}

int varA = GetIntNumberFromUser("Введите целове число:", "Ошибка ввода!");
Console.WriteLine($"A = {varA}");