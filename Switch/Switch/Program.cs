Console.Title = "switch";

//if else,if else, if else, if else etc etc is very messy and complex; instead
// switch (variable-name) { case value1 : statement; break ; REPEAT
// when no condtions are met use default : statment; break ; -- to end the switch loop without an error
//int num = 3;
string dayyy;

//my attempt to request user input for a day
Console.WriteLine("Please enter a number from 1-7: ");
double num = Convert.ToDouble(Console.ReadLine());

switch (num)
{
    case 1: dayyy = "Monday"; break;
    case 2: dayyy = "Tuesday"; break;
    case 3: dayyy = "Wednesday"; break;
    case 4: dayyy = "Thursday"; break;
    case 5: dayyy = "Friday"; break;
    case 6: dayyy = "Saturday"; break;
    case 7: dayyy = "Sunday"; break;
    default: dayyy = "not a day, homie. Learn to read directions maybe"; break;
}

Console.WriteLine("\n\nDay " + num + " in the week is " + dayyy + ".");
Console.ReadKey();
