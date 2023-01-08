// максимум двух чисел
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.Write("Numbers are equal");
}
else
{
    Console.Write("max = ");
    if (a > b)
    {
        Console.Write(a);
    }
    else
    {
        Console.Write(b);
    }
}
