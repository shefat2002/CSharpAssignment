using System;

double sales = Convert.ToDouble(Console.ReadLine());
double commissionRate = 0;

if (sales >= 0 && sales <= 1000)
{
    commissionRate = 0.01;
}
else if (sales >= 1001 && sales <= 2000)
{
    commissionRate = 0.02;
}
else if (sales >= 2001 && sales <= 3000)
{
    commissionRate = 0.03;
}
else if (sales >= 3001 && sales <= 4000)
{
    commissionRate = 0.04;
}
else if (sales >= 4001)
{
    commissionRate = 0.05;
}

double commission = sales * commissionRate;
Console.WriteLine(commission);