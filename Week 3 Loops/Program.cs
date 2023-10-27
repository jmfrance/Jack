using System.ComponentModel.Design;
using System.Reflection.Emit;

Console.WriteLine("Programming Portfolio results calculator");
double digTotal = 0;
double digRounded = 0;
int digPort = -1;
if (digPort < 0)
{ 
    Console.WriteLine("What was the digital portfolio mark? (out of 35)"); ;
    diglabel: 
    digPort = int.Parse(Console.ReadLine());
    if (digPort >= 0 && digPort <= 35)
    {
        double digPercent = ((2.857) * digPort);
        digRounded = (double)Math.Round(digPercent, 2);
        digTotal = digRounded * 0.5; 
        Console.WriteLine($"{digRounded}%");
    }
    while (digPort < 0 || digPort > 35)
    {
        Console.WriteLine("Please enter a value between 0 and 35."); ;
        goto diglabel;

    }
}

double openTotal = 0;
double openRounded = 0;
int openBook = -1;
if (openBook < 0)
{
    Console.WriteLine("What was the open book mark? (out of 7)"); ;
    openlabel:
    openBook = int.Parse(Console.ReadLine());
    if (openBook >= 0 && openBook <= 7)
    {
        double openPercent = ((14.286) * openBook);
        openRounded = (double)Math.Round(openPercent, 2);
        openTotal = openRounded * 0.25;
        Console.WriteLine($"{openRounded}%");
    }
    while (openBook < 0 || openBook > 7)
    {
        Console.WriteLine("Please enter a value between 0 and 7.");
        goto openlabel;
    }
}

double capTotal = 0;
double capRounded = 0;
int capstone = -1;
if (capstone < 0)
{
    Console.WriteLine("What was the capstone project mark? (out of 100)");
    caplabel:
    capstone = int.Parse(Console.ReadLine());
    if (capstone >= 0 && capstone <= 100)
    {
        double capPercent = ((1) * capstone);
        capRounded = (double)Math.Round(capPercent, 2);
        capTotal = capRounded * 0.25;
        Console.WriteLine($"{capRounded}%");
    }
    while (capstone < 0 || capstone > 100)
    {
        Console.WriteLine("Please enter a value between 0 and 100."); ;
        goto caplabel;
    }
}

double total = capTotal + openTotal + digTotal;
if (capTotal >= 40 && openTotal >= 40)
{
    if (total >= 70)
    {
        Console.WriteLine($"Congratulations, you got a 1st with a percentage of {total}");
    }
    else if (total >= 60 && total < 70)
    {
        Console.WriteLine($"Congratulations, you got a 2:1 with a percentage of {total}");
    }
    else if (total >= 50 && total < 60)
    {
        Console.WriteLine($"Congratulations, you got a 2:2 with a percentage of {total}");
    }
    else if (total >= 40 && total < 50)
    {
        Console.WriteLine($"Congratulations, you got a 2:2 with a percentage of {total}");
    }
}
