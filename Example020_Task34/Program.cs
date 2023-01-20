// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

int[] CreateRandomArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return(array);
}

int CountEvenElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result += 1;
    }
    return result;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    Console.Write($"[{array[0]}");
    int i = 1;
    while (i < len)
    {
        Console.Write($", {array[i]}");
        i++;
    }
    Console.Write("]");
}



int[] array = CreateRandomArray(GetIntPosNumberFromUser("Введите количество элементов массива:", "Ошибка Ввода!"));

PrintArray(array);
Console.Write($" -> {CountEvenElements(array)}");
