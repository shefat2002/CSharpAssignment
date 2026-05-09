using System;

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double largest = a;
if (b > largest)
{
    largest = b;
}
if (c > largest)
{
    largest = c;
}

Console.WriteLine(largest);