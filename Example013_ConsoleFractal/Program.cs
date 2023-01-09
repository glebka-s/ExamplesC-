Console.Clear();
//Console.SetCursorPosition(10, 4); // отступ от левого и верхнего краёв соответственно
//Console.WriteLine("#");

int xa = 30, ya = 1,
    xb = 1, yb = 20,
    xc = 60, yc = 20;

string symbol = "o";

Console.SetCursorPosition(xa, ya);
Console.WriteLine(symbol);

Console.SetCursorPosition(xb, yb);
Console.WriteLine(symbol);

Console.SetCursorPosition(xc, yc);
Console.WriteLine(symbol);

ya += 1;
yb += 1;
yc += 1;

int x = xa, y = xb;

int i = 0, count = 10000; // количество итераций

while(i < count)
{
    int what = new Random().Next(0, 3); // [0, 3)

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;   
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;   
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;   
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine(symbol);

    i++;
}