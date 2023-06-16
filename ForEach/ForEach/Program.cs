Console.Title = "ForEach";

//syntax: foreach(data-type variable-name in array-name){statements};
//check all elements in an array to access all stored values
//essentially does a set action for all values in an array(list of values)

//this creates an array with set values
string[] websites = new string[5]
    {"Google","YouTube","Facebook","Baidu","Yahoo!" };
Console.WriteLine("Popular Websites...");

//this has each value written with the provided statement
int rank = 1;
foreach (string site in websites)
{
    Console.WriteLine("Position: " + rank + "\t" + site);
    rank++;
}

Console.ReadKey();
