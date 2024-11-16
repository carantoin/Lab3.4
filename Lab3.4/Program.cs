Console.WriteLine("┌---------------------------------------┐");
Console.WriteLine($"|        x          |         y         |");
Console.WriteLine("|---------------------------------------|");
for (double x = -2; x <= 3; x = +0.2)
{
    double y;
    if (x > 1.5) y = 2 * Math.Pow(x, 3) - 30;
    else if (x >= 0 && x <= 1.5) y = x - 2;
    else y = x * x * x * x * x;
    Console.WriteLine($"|       {x,-5:F2}       |       {y,5:F2}       |");
}
Console.WriteLine("└---------------------------------------┘");