Console.Title = "Condition";

int a = 8;
int b = 3;


// ?: is a ternary operator or "conditional" operator
// (test expression) ? if-true-do-this : if-false-do-this;
string verb = (a != 1) ? " are " : " is ";
Console.WriteLine("There" + verb + a + "\n");

string parity = ( a % 2 != 0) ? "odd" : "even";
Console.WriteLine(a + " is " + parity);

parity = (b % 2 != 0) ? "odd" : "even";
Console.WriteLine(b + " is " + parity);

int max = (a > b)?a:b;
Console.WriteLine("\nMaximum is " +  max);
Console.ReadKey();



