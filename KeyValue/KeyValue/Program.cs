Console.Title = "KeyValue";

//another way to use foreach
//syntax: Dictionary < data-type, data-type> ditionary-name = 
            //new Dictionary <data-type, data-type> ();

//creating a dictionary
Dictionary<string, string> BookList =
    new Dictionary<string, string>();
BookList.Add("Michael Price", "Microsoft 365");
BookList.Add("Nick Vandome", "Windows 11");
BookList.Add("Mike McGrath", "Java");

Console.WriteLine("Popular Titles: ");

foreach(KeyValuePair<string, string> book in BookList)
{
    Console.WriteLine("Key: " + book.Key + "\tValue: " + book.Value + " in easy steps");
}

Console.ReadKey();  
