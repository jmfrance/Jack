Console.WriteLine("Welcome to the AMAZING Nicorama Cage-athon!");
Console.WriteLine("A celebration of 30 years of Nic Cage.");
 
Console.WriteLine("1. The Rock(1996)(15)");
Console.WriteLine("2. Face / Off(1997)(18)");
Console.WriteLine("3. The Wicker Man(2005) (12)");
Console.WriteLine("4. The Croods(2012)(U)");
 
Console.WriteLine("What film would you like to see?");
 
string filmSelectionString = Console.ReadLine();
 
Console.WriteLine("How old are you?");

int ageInt = int.Parse(Console.ReadLine());
string ageString = Console.ReadLine();

if (filmSelectionString == "1" && ageInt >=15)
{
    Console.WriteLine("You have selected The Rock");
    Console.WriteLine("Enjoy the film!");
}
else
{
    Console.WriteLine("too young");
}








if (filmSelectionString == "2")
{
    Console.WriteLine("You have selected Face / Off");
    Console.WriteLine("Enjoy the film!");
}
