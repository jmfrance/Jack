/*
This pizza shop application asks the user for the value of their food in pounds.
 
If the value of the food is at least £10 then they can get free delivery - otherwise you need to charge an extra £2 for delivery.
 
If the value of the food is more than £14 then they can get free delivery and a free garlic bread.
*/

Console.WriteLine("Welcome to the Pizza Shop Application!");

Console.WriteLine("What was the value of your order?");

float orderValue = float.Parse(Console.ReadLine());

if (orderValue >= 10 && orderValue < 14)
{
    Console.WriteLine("Your order qualifies for free delivery!");
}
else if (orderValue >= 14)
{
    Console.WriteLine("Your order qualifies for free delivery and free garlic bread!");
}
else
{
    Console.WriteLine("Your order will have a £2 delivery fee.");
}

