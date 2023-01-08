// третья цифра числа
int N = Convert.ToInt32(Console.ReadLine());
if (N < 100)
{
    Console.Write("третьей цифры нет");
}
else
{   
    int M = 0;
    while (N >= 100)
    {
        M = N % 10;
        N /= 10;
    }
    Console.Write(M);
}