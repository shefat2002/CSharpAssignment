using System;

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double[] numbers = { a, b, c };
Array.Sort(numbers);

Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");