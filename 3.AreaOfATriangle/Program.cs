using System;

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double s = (a + b + c) / 2;
double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
Console.WriteLine(area);