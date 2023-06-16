Console.Title = "Arithmetic";

int a = 8;
int b = 4;

Console.WriteLine("Addition:\t" + (a + b));
Console.WriteLine("Subtraction:\t"+ (a-b));
Console.WriteLine("Multiplication:\t" + (a * b));
Console.WriteLine("Division:\t" + (a / b));
Console.WriteLine("Modulus:\t" + (a%b));


// adding ++ after the value changes the value after printing
Console.WriteLine("\nPostfix Increment:\t"+ (a++)  );
Console.WriteLine("Prefix Result......:\t" + a);

//adding ++ before changes the value before printing
Console.WriteLine("\nPrefix Increment:\t" + (++b));
Console.WriteLine("Prefix Result......:\t" + b);
Console.ReadKey();

