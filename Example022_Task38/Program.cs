// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

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

double[] CreateDoubleArray(int N)
{
    double[] array = new double[N];
    int i = 0;
    while (i < N)
    {   
        double a;
        while (true)
        {   
            if (double.TryParse(Console.ReadLine() ?? "", out a))
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        array[i] = a;
        i++;
    }
    return(array);
}

double DifferenceMinMax (double[] array)
{
    double min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];

        if (array[i] < max)
            min = array[i];
    }
    return (max - min);
}

void PrintArray(double[] array)
{
    Console.Write($"[{array[0]}");
    int i = 1;
    while (i < array.Length)
    {
        Console.Write($", {array[i]}");
        i++;
    }
    Console.Write("]");
}


double[] array = CreateDoubleArray(GetIntPosNumberFromUser("Введите количество элементов", "Ошибка ввода!"));

PrintArray(array);
Console.Write($" -> {DifferenceMinMax(array)}");
