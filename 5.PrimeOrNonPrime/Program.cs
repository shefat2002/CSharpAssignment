using System;

int number = Convert.ToInt32(Console.ReadLine());
bool isPrime = true;

if (number <= 1)
{
    isPrime = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
{
    Console.WriteLine("Prime");
}
else
{
    Console.WriteLine("Non-Prime");
}