Console.Title = "Assign";

int a;
int b;


//in all of these cases, the answer to the equation is assigned to the first listed value
// example a+= b becomes >>> a = (a+b)
Console.Write("Assign Values: ");
Console.Write("\ta= " + (a = 8));
Console.WriteLine("\tb= " + (b = 4));

Console.Write("\n\nAdd and Assign: ");
Console.Write("\ta += b (8 += 4)\ta= " + (a += b));

Console.Write("\n\nSubtract and Assign: ");
Console.Write("\ta -= b (12 -= 4)\ta= " + (a-=b));

Console.Write("\n\nMultiply and Assign: ");
Console.Write("\ta*=b (8 *= 4)\ta= "+ (a*=b));

Console.Write("\n\nDivide and Assign: ");
Console.Write("\ta/=b (32 /= 4)\ta= " + (a/=b));

//this divides traditionally then assigns the remainder to the first value
//so 8 / 4 is 2 with 0 remainder. so the first value would become 0
Console.Write("\n\nModulus Assign: ");
Console.Write("\ta%=b (8 %= 4)\ta= " + (a%=b));

Console.ReadKey();

