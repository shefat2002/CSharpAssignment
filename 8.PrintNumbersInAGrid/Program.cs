using System;

for (int i = 1; i <= 9; i++)
{
    Console.Write(i + (i % 3 == 0 ? "" : " "));
    if (i % 3 == 0)
    {
        Console.WriteLine();
    }
}