// таблица кубов чисел от 1 до N

int N;
// ввод
while (true)
{
    Console.Write("Введите положительное число N: ");
    if (int.TryParse(Console.ReadLine(), out N))
    {
        if (N > 0)
            break;
    }
    Console.WriteLine("Ошибка ввода!");
}

Console.Write($"{N} -> 1");
int i = 2;

while (i <= N)
{
    Console.Write($",{Math.Pow(i,3)}");
    i++;
}
