Console.Title = "Logic";


bool yes = true, no = false;
 //both conditions are true
Console.Write("AND Logic:");
Console.Write("\t(yes && yes) : " + (yes && yes));
Console.Write("\n\t\t (yes && no) : " + (yes && no));
Console.Write("\n\t\t ( no && no) : " + (no && no));

//only one condition is true
Console.Write("\n\nOR Logic:");
Console.Write("\t(yes || yes) : " + (yes || yes));
Console.Write("\n\t\t (yes || no) : " + (yes || no));
Console.Write("\n\t\t ( no || no) : " + (no || no));

//! NOT inverts the value
Console.Write("\n\nNOT Logic:");
Console.Write("\t yes = " + yes);
//yes is changes to no
Console.Write("\t !yes = " + !yes);
Console.Write("\n\t\t no = " + no);
//no is changed to yes
Console.Write("\t !no = " + !no);

Console.ReadKey();


