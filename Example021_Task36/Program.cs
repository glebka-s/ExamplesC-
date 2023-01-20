// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

// пусть числа будут принадлежать интервалу (-100, 100)
int[] CreateRandomArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return(array);
}

int SumOfElementsWithUnevenIndex(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            result += array[i];
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
Console.Write($" -> {SumOfElementsWithUnevenIndex(array)}");
