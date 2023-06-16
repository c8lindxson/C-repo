Console.Title = "IfElse";

Console.Write("Please Enter A Number: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.Write("Thanks. Now Enter A Letter: ");
//originally the code only accepts capitals so i am adding code to change that
char letter = Convert.ToChar(Console.ReadLine());
//string input = Console.ReadLine().ToUpper;

if (num >= 6)
{
    Console.WriteLine("\nNumber Exceeds 5");
    //nested statement to be inserted here
//  adding || creates a logical OR statement that allows for both conditions 
    if (letter == 'C' || letter == 'c')
    {
        Console.WriteLine("Letter is C");
    }
}
else
{
    Console.WriteLine("\nNumber is 5 Or Less");
}
Console.ReadKey();