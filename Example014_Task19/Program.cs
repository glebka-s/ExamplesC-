// является ли пятизначное число палиндромом
int N;

while (true)
{
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out N))
    {
        if (N > 9999 && N < 100000)
        break;
    }

    Console.WriteLine("Ошибка ввода!");
}

int a1 = N / 10000;
int a2 = (N % 10000) / 1000;
int a5 = N % 10;
int a4 = (N % 100) / 10;

if (a1 == a5 && a2 == a4)
{
    Console.Write($"{N} -> да");
}
else
{
    Console.Write($"{N} -> нет");
}