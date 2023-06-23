Console.Clear();
Random random = new Random();
int count = 0;
int max = 3;
int min = 0;
int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yc = 20;
int x = xa, y = ya;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");


while(count < 2)
{
    int what = random.Next(min, max);
    switch (what)
    {
        case 0:
            x = (x + xa) / 2;
            y = (y + ya) / 2;
        break;
        case 1:
            x = (x + xb) / 2;
            y = (y + yb) / 2;
            break;
        case 2:
            x = (x + xc) / 2;
            y = (y + yc) / 2;
            break;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count ++;
}