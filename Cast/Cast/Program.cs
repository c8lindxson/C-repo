Console.Title = "Cast";

double num = 10.5;
int interger = 2;

num = num + interger;
Console.WriteLine("Implicit Cast: " + num);

num = (double)7 / interger;
Console.WriteLine("Explicit Cast: " + num);

num = 7 / interger;
Console.WriteLine("No double: " + num);

char letter = (char)65;
Console.WriteLine("Cast Interger: " + letter);

int unicode = (int)'A';
Console.WriteLine("Cast Letter: " + unicode);

Console.ReadKey();

