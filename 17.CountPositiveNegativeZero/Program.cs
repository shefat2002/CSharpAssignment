using System;

int positiveCount = 0;
int negativeCount = 0;
int zeroCount = 0;

string input;
while ((input = Console.ReadLine()) != null && input.Trim() != "")
{
    string[] tokens = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
    foreach (string token in tokens)
    {
        if (double.TryParse(token, out double number))
        {
            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }
        }
    }
}

Console.WriteLine(positiveCount);
Console.WriteLine(negativeCount);
Console.WriteLine(zeroCount);