// максимальное трёх чисел
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && a == c)
{
    Console.Write("Numbers are equal");
}

if (a > b && a > c)
{
    Console.Write("max = ");
    Console.Write(a);
}

if (b > a && b > c)
{
    Console.Write("max = ");
    Console.Write(b);
}

if (c > a && c > b)
{
    Console.Write("max = ");
    Console.Write(c);
}