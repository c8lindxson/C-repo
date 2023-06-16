Console.Title = "For Loop";

//for (initializer; test-expressin; updater {statments}
for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Loop Iteration: " + i);
    //nested loops begin here
    for(int j = 1; j < 4; j++)
    {
        Console.WriteLine("\tInner Loop Iteration: " + j);
    }
}
Console.ReadKey();