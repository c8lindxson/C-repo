Console.Title = "Conversion";
Console.Write("Please enter a number: ");
double num = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Now enter another number: ");
double sum  = num + Convert.ToDouble(Console.ReadLine());   
Console.WriteLine("Total = " + sum);
Console.ReadKey();
