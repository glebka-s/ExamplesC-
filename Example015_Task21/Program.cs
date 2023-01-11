void PrintArray(double[] array)
{
    int len = array.Length;
    Console.Write(array[0]);
    int i = 1;
    while (i < len)
    {
        Console.Write($",{array[i]}");
        i++;
    }
}

// ввод координат первой точки
Console.WriteLine("Введите координаты первой точки");

double[] A = new double[3];

int i = 0;
while(i < 3)
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out A[i]))
            break;
        Console.WriteLine("Ошибка ввода!");
    }

    i++;
}

// ввод координат второй точки
Console.WriteLine("Введите координаты второй точки");

double[] B = new double[3];

i = 0;
while(i < 3)
{
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out B[i]))
            break;
        Console.WriteLine("Ошибка ввода!");
    }

    i++;
}

// вычисления
double distantion = 0;

i = 0;

while(i < 3)
{
    distantion += Math.Pow((B[i] - A[i]), 2);
    i++;
}

distantion = Math.Round(Math.Sqrt(distantion), 2);

Console.Write("A("); PrintArray(A); Console.Write("); ");
Console.Write("B("); PrintArray(B); Console.Write(") -> ");
Console.Write(distantion);
