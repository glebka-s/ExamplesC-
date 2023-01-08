// все чётные числа от 1 до N
int N = Convert.ToInt32(Console.ReadLine());
if (N < 2)
{
    Console.Write("Нет таких чётных чисел");
}
else
{   
    int i = 2;
    Console.Write(i);
    i += 2;
    while (i <= N)
    {
        Console.Write(", ");
        Console.Write(i);
        i += 2;
    }
}